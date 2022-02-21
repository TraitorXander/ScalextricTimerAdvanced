import sys
import os
from Common import sec_to_ms
import RPi.GPIO as GPIO
import time

sensor_chan = 17

def sensor_callback(channel):
    timestamp = time.time()

def main():
    sensor_callback(sensor_chan)

    try:
        while True:
            time.sleep(sec_to_ms(10))
    except KeyboardInterrupt:
        # Reset GPIO
        GPIO.cleanup()