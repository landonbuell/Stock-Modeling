"""
Landon Buell
Stock Trading
Ticker Class
29 Nov 2020
"""

            #### IMPORTS ####

import numpy as np
import matplotlib.pyplot as plt
import os
import pandas as pd
import yfinance as yf


            #### CLASS DEFINTIONS ####
    
class Ticker :
    """
    Class to hold a ticker and associated Data
    --------------------------------
    tickerName (str) : Name of ticker as appears in market index
    --------------------------------
    """

    def __init__(self,tickerName):
        """ Constructor for Ticker Instance """
        self._tickerName = tickerName

    def LoadMarketData(self):
        """ Use Yahoo-Finance API to load Time-Series market data """
