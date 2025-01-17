import matplotlib.pyplot as plt

# Sample data
materials = {
    'Steel': {'strain': [0, 0.002, 0.004, 0.006, 0.008], 'stress': [0, 250, 500, 750, 1000]},
    'Aluminum': {'strain': [0, 0.001, 0.002, 0.003, 0.004], 'stress': [0, 150, 300, 450, 600]}
}

# Plotting
for material, data in materials.items():
    plt.plot(data['strain'], data['stress'], label=material)

plt.xlabel('Strain')
plt.ylabel('Stress (MPa)')
plt.title('Stress-Strain Curves')
plt.legend()
plt.grid(True)
plt.show()
