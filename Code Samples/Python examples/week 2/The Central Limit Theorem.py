import numpy as np
import pandas as pd

samples_all = []
samples_all_exp = []
samples_all_possion = []
samples_all_geometric = []
mu = .9
lam = 1.0
size=1000

for number_in_sample in range(1,20000):
    samples = np.random.binomial(1, mu, size=size)
    samples_all.append(samples.mean())
    samples = np.random.exponential(scale=2.0,size=size)
    samples_all_exp.append(samples.mean())
    samples = np.random.geometric(p=.5, size=size)
    samples_all_geometric.append(samples.mean())
    samples = np.random.poisson (lam=lam, size=size)
    samples_all_possion.append(samples.mean()) 

df = pd.DataFrame({ 'binomial' : samples_all, 
                     'poission' : samples_all_possion,
                     'geometric' : samples_all_geometric,
                    'exponential' : samples_all_exp})
					
from IPython.core.pylabtools import figsize
from matplotlib import pyplot as plt
figsize(11, 6)
fig, axes = plt.subplots(nrows=2, ncols=2)
df.binomial.hist(color='blue',ax=axes[0,0], alpha=0.9, bins=1000)
df.exponential.hist(ax=axes[0,1],color='r',bins=1000)
df.poission.hist(ax=axes[1,0],color='r',bins=1000)
df.geometric.hist(ax=axes[1,1],color='r',bins=1000)

axes[0,0].set_title('Binomial')
axes[0,1].set_title('Poisson')
axes[1,0].set_title('Geometric')
axes[1,1].set_title('Exponential')

plt.show()