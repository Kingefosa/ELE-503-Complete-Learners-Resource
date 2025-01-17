
import scipy.stats as stats

# Sample data for two groups
group1 = [20, 22, 19, 24, 30]
group2 = [25, 27, 23, 28, 35]

# Perform independent t-test
t_stat, p_value = stats.ttest_ind(group1, group2)

print(f"T-Statistic: {t_stat}")
print(f"P-Value: {p_value}")

# Interpretation
alpha = 0.05
if p_value < alpha:
    print("Reject the null hypothesis: Significant difference between groups.")
else:
    print("Fail to reject the null hypothesis: No significant difference between groups.")
