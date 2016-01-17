#!/bin/sh

while true 
do
  echo 'Wating for script file change'
  inotifywait -qe close_write ./../howard/wwwroot/scripts/pi.py
  echo 'Wait complete. Executing command'
  sudo python ./../howard/wwwroot/scripts/pi.py
  echo 'Execution complete'
done

