#!/bin/python3

import sys
import os



# Add Celsius class implementation below.
class Celsius:

    # def __init__(self, temperature):
    #     self.temperature=temperature

    def __get__(self, obj, owner):
        return  ((obj.fahrenheit-32)*5)/9

    def __set__(self, obj, value):
        obj.fahrenheit=(9*float(value)/5)+32

# Add temperature class implementation below.        
class Temperature:
    
    def __init__(self, rawTemp):
        self.rawTemp=rawTemp

    @property
    def fahrenheit(self):
        return self.rawTemp
    @fahrenheit.setter
    def fahrenheit(self, value):
        self.rawTemp=float(value)

    celsius=Celsius()
        
'''Check the Tail section for input/output'''

if __name__ == "__main__":
    with open(os.environ['OUTPUT_PATH'], 'w') as fout:
        res_lst = list()
        t1 = Temperature(int(input()))
        res_lst.append((t1.fahrenheit, t1.celsius))
        t1.celsius = int(input())
        res_lst.append((t1.fahrenheit, t1.celsius))
        fout.write("{}\n{}".format(*res_lst))