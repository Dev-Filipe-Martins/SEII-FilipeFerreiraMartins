#!/bin/bash

if [ ${1,,} = Filipe ]; then
	echo "Oh, you're the boss here. Welcome!"
elif [ ${1,,} = help ]; then
	echo "Just enter your username, duh!"
else
	echo "I don't know who you are. But you're not the boss of me!"
fi
