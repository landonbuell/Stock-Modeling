"""
Landon Buell
Stock Trading
Program Utilities
29 Nov 2020
"""

            #### IMPORTS ####

import numpy as np
import matplotlib.pyplot as plt
import os
import sys
import datetime as dt

            #### CLASS DEFINTIONS ####

class ProgramStart :
    """
    Class To Initialize all peices of the program at startup
    """

    def __init__(self):
        """ Initialize ProgramStart Instance """
        self._timeStart = self.GetCurrentTime()

    def GetCommandLineArgs (self):
        """ Use Sys Module to collect command line Args """
        return sys.argv[1:]

    @staticmethod
    def GetCurrentTime ():
        """ Get Current Local time in YYYY.MM.DD.HH.MM.SS Format """
        currentTime = dt.datetime.now().isoformat(sep=".")
        currentTime = currentTime.replace(":",".")
        currentTime = currentTime.replace("-",".")
        return currentTime

    def Call (self):
        """ Run Program Start Instance """
        pass

    def __str__(self):
        """ Return Print Friendly version of class """
        return "ProgramStart Object Created at: " + self._timeStart


class ProgramFinish : 
    """
    Class To Finialize all peices of the program at Termination
    """

    def __init__(self):
        """ Initialize ProgramFinish Instance """
        pass

    def Call (self):
        """ Run ProgramFinish Instance """
        pass