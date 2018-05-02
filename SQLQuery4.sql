SELECT  InteriorFeaturesID, InterriorFeaturesHallShowerDate,InterriorFeaturesWaterHeaterDate,InterriorFeaturesCelingFanDate,InterriorFeaturesFurnanceReplacement FROM InteriorFeatures
WHERE InteriorFeaturesID = (SELECT fk_InterriorFeaturesID FROM House WHERE HouseID = 4)

SELECT * FROM dbo.ExteriorFeatures
SELECT * FROM H