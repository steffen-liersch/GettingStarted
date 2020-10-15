#!/bin/bash

# https://linux.die.net/man/1/ash

if [ -z "$IS_SUB_SHELL" ]; then
  export IS_SUB_SHELL=1
  export PS1="\e[1m\w\e[0m \$ "
  info
fi
