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

    TSLA = yf.download(tickers=['TSLA'],period='max')

    print(TSLA.head(20))
    print(TSLA.shape)

    print(sys.getsizeof(TSLA))

    x = TSLA.index
    y1 = TSLA['Open']
    y2 = TSLA['Close']

    plt.plot(x,y1,color='blue',label='Open')
    plt.plot(x,y2,color='orange',label='Close')
    plt.grid()
    plt.legend()
    plt.show()
    

    