import sys
import os
from time import sleep

#sys.path.append(".")
from LapTimer import LapTimer


def test_1():
    try:
        print("Test 1...\n")
        timer_1 = LapTimer()
        timer_1.start()
        sleep(sec_to_ms(2355))
        timer_1.stop()
        print(str(timer_1.get_time_elapsed()) + "s")

    except Exception as exc:
        print(str(type(exc)) + "\n" + str(exc))


def sec_to_ms(sec):
    return sec / 1000.0


if __name__ == "__main__":
    test_1()
