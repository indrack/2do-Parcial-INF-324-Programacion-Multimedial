# -*- coding: utf-8 -*-

import cv2
import numpy as np
image = cv2.imread('lagot.png')
#Recortar una imagen
height, width = image.shape[0:2]

iniFila = int(height*.45)

iniCol = int(width*.45)

finFila = int(height*.55)

finCol = int(width*.55)



segmentoImage = image[iniFila:finFila, iniCol:finCol]


imagenBordes = cv2.Canny(segmentoImage,100,200)

cv2.imshow("Bordes detectados", imagenBordes)


cv2.imshow('Imagen Original', image)

cv2.imshow('Imagen segmentada', segmentoImage)

cv2.waitKey(0)