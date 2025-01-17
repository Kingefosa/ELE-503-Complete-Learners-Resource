from scipy.optimize import minimize

# Define the cost function
def cost_function(x):
    return x**2 + 4*x + 4

# Initial guess
x0 = 0.0

# Perform optimization
result = minimize(cost_function, x0)

print(f"Minimum at x = {result.x[0]}, f(x) = {result.fun}")
