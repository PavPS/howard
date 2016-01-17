#!/bin/sh

while true 
do
  if [ -f  ./../howard/wwwroot/scripts/pi.py ]; then
    echo 'Wating for script file change'
    inotifywait -qe close_write ./../howard/wwwroot/scripts/pi.py
    echo 'Wait complete. Executing command'
    sudo python ./../howard/wwwroot/scripts/pi.py
    echo 'Execution complete'
  else
    echo 'File is missing...'
    sleep 1
  fi
done

