#!/usr/bin/perl
use warnings;
use strict;
use File::Basename qw(dirname basename fileparse);
use File::Spec;
use File::Copy;
use File::Path;

# OpenSUSE system dependencies
# TODO: Can the version numbers be forced in zypper so the system can be duplicated 100%?
# (svn) (git)
# automake
#	autoconf automake m4
# mono-core mono-devel
#	glib2-devel glibc-devel libgdiplus0 linux-kernel-headers mono-core mono-data mono-data-sqlite mono-devel mono-extras mono-web mono-winforms
# mono-addins
#	glib-sharp2 gtk-sharp2 mono-addins
# intltool
#	gettext-tools intltool
# glade-sharp2
# monodoc-core
# mono-nunit
# make
# nant
# java-1_6_0-sun

my $root = File::Spec->rel2abs( dirname($0) );

my $nant = "nant";

die "MonoDevelop for Mac must be built on a Linux machine" if $^O ne "linux";

if (!$ENV{UNITY_THISISABUILDMACHINE})
{
	chdir "$root/monodevelop";
	system ("git pull") && die ("failed to update monodevelop");
	chdir "$root/MonoDevelop.Debugger.Soft.Unity";
	system ("git pull") && die ("failed to update MonoDevelop.Debugger.Soft.Unity");
	chdir "$root/boo";
	system ("git pull") && die ("failed to update boo");
	chdir "$root/unityscript";
	system ("git pull") && die ("failed to update unityscript");
	chdir "$root/boo-md-addins";
	system ("git pull") && die ("failed to update boo-md-addins");
}
chdir $root;

# Check sources
die ("Must grab Unity MonoDevelop source from github first") if !-d "monodevelop";
die ("Must grab Unity MonoDevelop Soft Debugger source from github first") if !-d "MonoDevelop.Debugger.Soft.Unity";
die ("Must grab Boo implementation") if !-d "boo";
die ("Must grab Boo extensions") if !-d "boo-extensions";
die ("Must grab Boo MD addins implementation") if !-d "boo-md-addins";
die ("Must grab Unityscript implementation") if !-d "unityscript";

chdir "$root/monodevelop";
system("./configure --profile=mac");
system("make");

chdir "$root/MonoDevelop.Debugger.Soft.Unity";
system("xbuild /property:Configuration=Release /t:Rebuild");

my $mdSource = "$root/monodevelop/main/build";
my $mdRoot = "$root/tmp/monodevelop";

chdir $root;
#mkpath "$mdRoot/bin";
#mkpath "$mdRoot/AddIns";
#mkpath "$mdRoot/data";
rmtree "tmp";
mkpath "tmp";
# TODO: First, we assembled the final monodevelop product in tmp/monodevelop, but now, currently (maybe temporarily) we need to build monodevelop, send the build folder to a mac and package it there, so the monodevelop dir needs all the bits in place before sending (can't be assembled in another folder)
system("ln -s ../monodevelop/main/build tmp/monodevelop");

# Unity soft debugger
mkpath "$mdRoot/AddIns/MonoDevelop.Debugger.Soft.Unity";
copy "$root/MonoDevelop.Debugger.Soft.Unity/obj/Release/MonoDevelop.Debugger.Soft.Unity.dll", "$mdRoot/AddIns/MonoDevelop.Debugger.Soft.Unity" or die ("Failed to copy MonoDevelop.Debugger.Soft.Unity");	

chdir "$root/boo";
system("$nant rebuild") && die ("Failed to build Boo");
mkpath "$mdRoot/AddIns/BackendBindings/Boo/boo";
system("rsync -av --exclude=*.mdb  \"$root/boo/build/\" \"$mdRoot/AddIns/BackendBindings/Boo/boo\"");

chdir "$root/boo-extensions";
system("$nant rebuild") && die ("Failed to build Boo");

chdir "$root/unityscript";
my $javascriptFiles =  "$mdRoot/AddIns/BackendBindings/UnityScript/bin";
mkpath $javascriptFiles;
rmtree "$root/unityscript/bin";
system("$nant rebuild") && die ("Failed to build UnityScript");
system("rsync -av --exclude=*.mdb --exclude=*Tests* --exclude=nunit* \"$root/unityscript/bin/\" \"$javascriptFiles\"");

chdir "$root/boo-md-addins";
copy "$root/dependencies/build.properties", "$root/boo-md-addins/build.properties";
system("$nant rebuild") && die ("Failed to build Boo based addins");
copy "$root/boo-md-addins/build/Boo.MonoDevelop.dll", "$mdRoot/AddIns/BackendBindings/Boo";
copy "$root/boo-md-addins/build/Boo.Ide.dll", "$mdRoot/AddIns/BackendBindings/Boo";
copy "$root/boo-md-addins/build/UnityScript.Ide.dll", "$mdRoot/AddIns/BackendBindings/Boo";
copy "$root/boo-md-addins/build/Boo.MonoDevelop.Util.dll", "$mdRoot/AddIns/BackendBindings/Boo";

copy "$root/boo-md-addins/build/UnityScript.MonoDevelop.dll", "$mdRoot/AddIns/BackendBindings/UnityScript";
copy "$root/boo-md-addins/build/UnityScript.Ide.dll", "$mdRoot/AddIns/BackendBindings/UnityScript";
copy "$root/boo-md-addins/build/Boo.Ide.dll", "$mdRoot/AddIns/BackendBindings/UnityScript";
copy "$root/boo-md-addins/build/Boo.MonoDevelop.Util.dll", "$mdRoot/AddIns/BackendBindings/UnityScript";

chdir "$root/monodevelop";
print "Collecting built files so they can be packaged on a mac\n";
unlink "MonoDevelop.tar.gz";
system("tar cfz MonoDevelop.tar.gz *");
move "MonoDevelop.tar.gz", "$root";
chdir "$root";
