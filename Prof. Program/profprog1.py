import pandas as pd
import matplotlib.pyplot as plt
#importing nessecary libraries for data handling
#NumPy method/function: .array, .shape, .min, .max, .mean, .sum, .genfromtext
#.copy, .concatenate, 
#Panda method/function: .head, .tail, .info, .loc, .value_counts, .max, .min
#.mean, .median, .mode, .sum, .describe, .drop

test_data = pd.read_csv('testdata.csv',index_col=0)

print("Welcome to the program!")
#test_data = test_data[1:]
print(test_data)
#print(test_data["ratings#"])
pause = input("")
#Look at a specific column and see what we want to do with it
print(test_data["language"])
pause = input("")
#Data is displayed. You can use this displayed data to decide how to clean and analyze this data.
langfilter = []
for i in test_data["language"]:
    if i == "ENG":
        langfilter.append(True)
    else:
        langfilter.append(False)
datalang = test_data[langfilter]
print(datalang)
pause = input("")
#Filtered out from the data non-ENG langauge items from the data.
#Look at another set now that extraneous data is removed
print(datalang["ratings#"])
pause = input("")
#panda allows you to get data specifics
ratingnumber = datalang["ratings#"]
print("Max: " + str(ratingnumber.max()))
print("Mean: " + str(ratingnumber.mean()))
print("Min: " + str(ratingnumber.min()))
pause = input("")
#By looking at the data, you can see there are outliers in the data for the number of ratings.
numfilter = []
for i in datalang["ratings#"]:
                  if i < 1000:
                      numfilter.append(False)
                  else:
                      numfilter.append(True)
above1000 = datalang[numfilter]
print(above1000)
pause = input("")
#Removes the entries in the data with a small amount of ratings that could skew the data.
newratestats = above1000["ratings#"]
print("Max: " + str(newratestats.max()))
print("Mean: " + str(newratestats.mean()))
print("Min: " + str(newratestats.min()))
pause = input("")
#Now we can see a more accurate array of statistics
plt.plot(above1000[],above1000[])
plt.show()
