import RPi.GPIO as GPIO
import time

# Blink

GPIO.setmode(GPIO.BCM)
GPIO.setup(21, GPIO.OUT)
GPIO.output(21, True)
time.sleep(1)

GPIO.cleanup()
