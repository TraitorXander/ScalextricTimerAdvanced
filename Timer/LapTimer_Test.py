import sys
import os
from time import sleep
from LapTimer import LapTimer
sys.path.append(".")
from Common import HelperMethods as HP


def test_1():
    try:
        print("Test 1...\n")
        timer_1 = LapTimer()
        timer_1.start()
        sleep(HP.sec_to_ms(2355))
        timer_1.stop()
        print(str(timer_1.get_time_elapsed()) + "s")

    except Exception as exc:
        print(str(type(exc)) + "\n" + str(exc))




if __name__ == "__main__":
    test_1()
