# -*- coding: utf-8 -*-
"""
Created on Sun May 15 22:41:42 2022

@author: Alejandro Tapia Jose Rodrigo
"""

from pyswip import Prolog
prolog = Prolog()
prolog.consult("hechos.pl")
prolog.consult("reglas.pl")
print("--------------------------------------------")
print("----------------SII----------------")
for elemento in prolog.query("padre(X,Y)"):
    print(elemento["X"], "es el padre de ",elemento["Y"])
print("--------------------ENTONCES-------------------")
print("----------------RELACION ABUELO----------------")
for elemento in prolog.query("abuelo(X,Y)"):
    print(elemento["X"], "es el abuelo de ",elemento["Y"])
print("----------------RELACION NIETO----------------")
for elemento in prolog.query("nieto(X,Y)"):
    print(elemento["X"], "es el nieto de ",elemento["Y"])
print("----------------RELACION PRIMOS----------------")
for elemento in prolog.query("primo(X,Y)"):
    print(elemento["X"], "es el primo de ",elemento["Y"])