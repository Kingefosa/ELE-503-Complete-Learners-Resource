import numpy as np
import pandas as pd

results = []
for num_throws in range(1,10000):
    throws = np.random.randint(low=1,high=6, size=num_throws)
    mean_of_throws = throws.mean()
    results.append(mean_of_throws)
	
df = pd.DataFrame({ 'throws' : results})

from IPython.core.pylabtools import figsize
from matplotlib import pyplot as plt
figsize(11, 9)
df.plot(title='Law of Large Numbers Explained Shown Graphically',color='r')
plt.xlabel("Number of throws in sample")
plt.ylabel("Average Of Sample")
plt.show()