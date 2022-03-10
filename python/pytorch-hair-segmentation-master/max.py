import cv2
import numpy as np
import os.path
from PIL import Image

#root_path는 사진폴더 위치
root_path = r"H:/Hair dataset/aaaa"
count = 0
aaa = 0
files = os.listdir(root_path)

format = [".jpg",".png",".jpeg","bmp",".JPG",".PNG","JPEG","BMP"]
for (path,dirs,files) in os.walk(root_path):
    for file in files:
        if file.endswith(tuple(format)):
             name = path+"/"+file
             image = cv2.imread(path+"/"+file)

             #template는 비교할 사진
             template = cv2.imread("image/hair7.PNG")
             th, tw = template.shape[:2]

             methods = ['cv2.TM_CCOEFF']
             for i, method_name in enumerate(methods):
                 img_draw = image
                 method = eval(method_name)
                 res = cv2.matchTemplate(img_draw, template, method)
                 min_val, max_val, min_loc, max_loc = cv2.minMaxLoc(res)

                 #print(max_val)

                 if max_val > aaa:
                     aaa = max_val
                     bbbb = name

                 print(aaa)
                 print(bbbb)
        count += 1
        if count > len(files):
            break