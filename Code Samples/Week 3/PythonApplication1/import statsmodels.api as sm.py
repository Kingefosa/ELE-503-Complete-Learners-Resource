
import statsmodels.api as sm
import pandas as pd

# Sample data
data = pd.DataFrame({
    'X': [1, 2, 3, 4, 5],
    'Y': [2, 4, 5, 4, 5]
})

# Define dependent and independent variables
X = data['X']
Y = data['Y']
X = sm.add_constant(X)  # Adds a constant term to the predictor

# Fit regression model
model = sm.OLS(Y, X).fit()

# Print summary
print(model.summary())
