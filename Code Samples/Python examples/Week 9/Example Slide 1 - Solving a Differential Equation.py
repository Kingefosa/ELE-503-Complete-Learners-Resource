import numpy as np
from scipy.integrate import odeint
import matplotlib.pyplot as plt

# Define parameters
omega = 2.0  # angular frequency

# Define the system of equations
def harmonic_oscillator(y, t, omega):
    x, v = y
    dxdt = v
    dvdt = -omega**2 * x
    return [dxdt, dvdt]

# Initial conditions
y0 = [1.0, 0.0]  # x=1, v=0

# Time points
t = np.linspace(0, 10, 100)

# Solve ODE
solution = odeint(harmonic_oscillator, y0, t, args=(omega,))

# Plot results
plt.plot(t, solution[:,0], label='x(t)')
plt.plot(t, solution[:,1], label='v(t)')
plt.legend()
plt.xlabel('Time')
plt.ylabel('Amplitude')
plt.title('Simple Harmonic Oscillator')
plt.show()
