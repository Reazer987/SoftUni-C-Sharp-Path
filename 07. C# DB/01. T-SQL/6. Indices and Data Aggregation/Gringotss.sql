--Problem 00
SELECT COUNT(*) AS [Count]
FROM [WizzardDeposits]

--Problem 01
SELECT MAX([MagicWandSize]) AS [LongestMagicWand]
FROM [WizzardDeposits]

--Problem 02
SELECT MAX([MagicWandSize]) AS [LongestMagicWand]
FROM [WizzardDeposits]

--Problem 03
  SELECT TOP(2) [DepositGroup]
    FROM [WizzardDeposits]
GROUP BY [DepositGroup]
ORDER BY AVG([MagicWandSize])

--Problem 04
SELECT [DepositGroup],MAX([MagicWandSize]) AS [LongestMagicWand]
FROM [WizzardDeposits]
GROUP BY [DepositGroup]

--Problem 05
   SELECT  [DepositGroup], SUM([DepositAmount]) AS[TotalSum]
     FROM [WizzardDeposits]
 GROUP BY [DepositGroup]

--Problem 06
    SELECT  [DepositGroup], SUM([DepositAmount]) AS[TotalSum]
      FROM [WizzardDeposits]
	 WHERE [MagicWandCreator]='Ollivander family'
  GROUP BY [DepositGroup]

--Problem 07
    SELECT  [DepositGroup], SUM([DepositAmount]) AS [TotalSum]
      FROM [WizzardDeposits]
	 WHERE [MagicWandCreator]= 'Ollivander family'
  GROUP BY [DepositGroup]
  HAVING SUM(DepositAmount) <150000
  ORDER BY [TotalSum] DESC


--Problem 08
    SELECT  [DepositGroup],[MagicWandCreator],  MIN([DepositCharge]) AS [MinDepositCharge]                                         
      FROM [WizzardDeposits]
  GROUP BY [DepositGroup], [MagicWandCreator]
  ORDER BY [MagicWandCreator], [DepositGroup]

  --Problem 09
SELECT [AgeByGroup] AS [AgeGroup], COUNT([AgeByGroup]) AS [WizzardCount]
FROM (SELECT 
		CASE 
			WHEN [Age] BETWEEN 0 AND 10 THEN '[0-10]'
			WHEN [Age] BETWEEN 11 AND 20 THEN '[11-20]'
			WHEN [Age] BETWEEN 21 AND 30 THEN '[21-30]'
			WHEN [Age] BETWEEN 31 AND 40 THEN '[31-40]'
			WHEN [Age] BETWEEN 41 AND 50 THEN '[41-50]'
			WHEN [Age] BETWEEN 51 AND 60 THEN '[51-60]'
			ELSE '[61+]'
		END AS [AgeByGroup]
		FROM [WizzardDeposits]) [AgeByGroupTable]
GROUP BY [AgeByGroup]


--Problem 10
 SELECT LEFT([FirstName], 1) AS [FirstLetter]
 FROM [WizzardDeposits]
 WHERE [DepositGroup] = 'Troll Chest'
GROUP BY LEFT([FirstName], 1) 
 ORDER BY([FirstLetter])


	  






SELECT *
FROM [WizzardDeposits]