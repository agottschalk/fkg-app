SELECT 
Girls.Name, Types.Type, Girls.NormalHp, Girls.NormalAtk, Girls.NormalDef, Girls.AwakeHp, Girls.AwakeAtk, Girls.AwakeDef, Girls.Steps, Girls.BloomAvailable
FROM Girls
INNER JOIN Types
ON Girls.Type = Types.Id
