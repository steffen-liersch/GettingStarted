#!/bin/sh

base=$(readlink -f $(dirname $0))
dotnet build --configuration Release "$base/HelloWorld.csproj"