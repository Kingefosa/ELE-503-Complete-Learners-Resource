import pandas as pd
import matplotlib.pyplot as plt

# Load data
data = pd.read_csv(':\Users\kinge\Downloads\ELE 503 Python codes\Week 9\\temperature_data.csv')

# Data preprocessing
data['Timestamp'] = pd.to_datetime(data['Timestamp'])
data.set_index('Timestamp', inplace=True)

# Compute moving average
data['Temp_MA'] = data['Temperature'].rolling(window=10).mean()

# Plot data
plt.figure(figsize=(10,5))
plt.plot(data.index, data['Temperature'], label='Temperature')
plt.plot(data.index, data['Temp_MA'], label='Moving Average', linewidth=2)
plt.legend()
plt.xlabel('Time')
plt.ylabel('Temperature (°C)')
plt.title('Temperature Over Time')
plt.show()
