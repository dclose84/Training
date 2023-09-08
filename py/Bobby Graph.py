import pandas as pd
import matplotlib.pyplot as plt

# Sample data
data = {
    'Prefac_Start_Helper': ['2024-02', '2024-02', '2024-02', '2024-02', '2024-02', '2024-04', '2024-04', '2024-04', '2024-04', '2024-04', '2024-04', '2024-04'],
    'Prefac_Labor': [33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33],
    'SL1_Start_Helper': ['2025-01', '2025-01', '2024-12', '2024-11', '2024-12', '2025-01', '2025-02', '2025-01', '2025-01', '2024-12', '2024-12', '2024-11'],
    'SL1_Labor': [15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15, 15],
    'SL2_Start_Helper': ['2025-01', '2025-01', '2025-01', '2024-12', '2025-01', '2025-01', '2025-02', '2025-01', '2025-02', '2024-12', '2024-12', '2024-12'],
    'SL2_Labor': [18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18]
}

# Create a DataFrame
df = pd.DataFrame(data)

# Convert date columns to datetime objects
df['Prefac_Start_Helper'] = pd.to_datetime(df['Prefac_Start_Helper'])
df['SL1_Start_Helper'] = pd.to_datetime(df['SL1_Start_Helper'])
df['SL2_Start_Helper'] = pd.to_datetime(df['SL2_Start_Helper'])

# Create a line chart
plt.figure(figsize=(10, 6))
plt.plot(df['Prefac_Start_Helper'], df['Prefac_Labor'], label='Prefac Labor')
plt.plot(df['SL1_Start_Helper'], df['SL1_Labor'], label='SL1 Labor')
plt.plot(df['SL2_Start_Helper'], df['SL2_Labor'], label='SL2 Labor')

# Customize the chart
plt.title('Labor Times Over Time')
plt.xlabel('Start Date')
plt.ylabel('Labor Hours')
plt.legend()

# Format the x-axis to display dates nicely
plt.gcf().autofmt_xdate()

# Show the chart
plt.show()
