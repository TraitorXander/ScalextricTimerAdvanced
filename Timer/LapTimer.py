import time


class LapTimer:
    def start(self):
        self.start_time = time.time()
        return True

    def stop(self):
        self.end_time = time.time()
        return True

    def get_time_elapsed(self):
        time_elapsed = self.end_time - self.start_time
        print(
            "Start time\t{0}\nEnd time\t{1}\nLapsed\t\t{2}".format(
                round(self.start_time, 3),
                round(self.end_time, 3),
                round(time_elapsed, 3),
            )
        )
        return round(time_elapsed, 3)
