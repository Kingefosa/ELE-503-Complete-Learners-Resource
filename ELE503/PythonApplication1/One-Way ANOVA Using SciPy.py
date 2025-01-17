import scipy.stats as stats

# Sample data for three groups
group1 = [20, 22, 19, 24, 30]
group2 = [25, 27, 23, 28, 35]
group3 = [30, 32, 29, 34, 40]

# Perform one-way ANOVA
f_stat, p_value = stats.f_oneway(group1, group2, group3)

print(f"F-Statistic: {f_stat}")
print(f"P-Value: {p_value}")

# Interpretation
alpha = 0.05
if p_value < alpha:
    print("Reject the null hypothesis: At least one group mean is different.")
else:
    print("Fail to reject the null hypothesis: No significant difference among group means.")

