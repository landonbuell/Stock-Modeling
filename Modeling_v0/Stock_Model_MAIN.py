"""
Landon Buell
Modeling v0
Main Executable
31 March 2020
"""

            #### IMPORTS ####

import numpy as np
import pandas as pd
import sys
import matplotlib.pyplot as plt

import yfinance as yf

if __name__ == '__main__':

    rawdata = yf.download(tickers=['TSLA','MSFT'],period='max')

    print(rawdata.head(20))

   
    

    