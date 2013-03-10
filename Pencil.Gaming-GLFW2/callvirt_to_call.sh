#!/bin/sh

cd ./bin/Release
md5sum Pencil.Gaming.dll
monodis Pencil.Gaming.dll --output=Pencil.Gaming.il
sed -i 's/callvirt instance void class Pencil.Gaming.Graphics.Gl/call instance void class Pencil.Gaming.Graphics.Gl/g' Pencil.Gaming.il
sed -i 's/callvirt instance void class Pencil.Gaming.GlfwDelegates/call instance void class Pencil.Gaming.GlfwDelegates/g' Pencil.Gaming.il
sed -i 's/callvirt instance void class Pencil.Gaming.Audio.AlDelegates/call instance void class Pencil.Gaming.Audio.AlDelegates/g' Pencil.Gaming.il
rm Pencil.Gaming.dll
ilasm /dll Pencil.Gaming.il
rm Pencil.Gaming.il
md5sum Pencil.Gaming.dll