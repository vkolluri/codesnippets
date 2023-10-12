DECLARE @json NVARCHAR(MAX)

SET @json = '...' -- Your JSON string

-- Parse reportDetails
SELECT 
    reportTypeCode,
    submitTypeCode,
    reportingEntityNumber,
    submittingReportingEntityNumber,
    reportingEntityReportReference,
    JSON_VALUE(twentyFourHourRule, '$.aggregationTypeCode') AS aggregationTypeCode,
    JSON_VALUE(twentyFourHourRule, '$.periodStart') AS periodStart,
    JSON_VALUE(twentyFourHourRule, '$.periodEnd') AS periodEnd,
    activitySectorCode,
    reportingEntityContactId
FROM OPENJSON (@json)
WITH (
    reportTypeCode INT '$.reportDetails.reportTypeCode',
    submitTypeCode INT '$.reportDetails.submitTypeCode',
    reportingEntityNumber INT '$.reportDetails.reportingEntityNumber',
    submittingReportingEntityNumber INT '$.reportDetails.submittingReportingEntityNumber',
    reportingEntityReportReference NVARCHAR(255) '$.reportDetails.reportingEntityReportReference',
    twentyFourHourRule NVARCHAR(MAX) AS JSON '$.reportDetails.twentyFourHourRule',
    activitySectorCode INT '$.reportDetails.activitySectorCode',
    reportingEntityContactId INT '$.reportDetails.reportingEntityContactId'
)

-- Parse definitions
SELECT 
    typeCode,
    refId,
    surname,
    givenName,
    nameOfEntity,
    telephoneNumber,
    dateOfBirth,
    countryOfResidenceCode,
    addressTypeCode,
    occupation,
    nameOfEmployer
FROM OPENJSON (@json, '$.definitions')
WITH (
    typeCode INT,
    refId NVARCHAR(255),
    surname NVARCHAR(255),
    givenName NVARCHAR(255),
    nameOfEntity NVARCHAR(255),
    telephoneNumber NVARCHAR(20),
    dateOfBirth DATE,
    countryOfResidenceCode NVARCHAR(10),
    addressTypeCode INT,
    occupation NVARCHAR(255),
    nameOfEmployer NVARCHAR(255)
)

-- Parse transactions
SELECT 
    reportingEntityLocationId,
    thresholdIndicator,
    reportingEntityTransactionReference,
    dateTimeOfTransaction,
    methodCode,
    amount,
    currencyCode,
    conductorTypeCode,
    conductorRefId,
    dispositionCode
FROM OPENJSON (@json, '$.transactions')
WITH (
    reportingEntityLocationId NVARCHAR(50),
    thresholdIndicator BIT '$.largeCashTransactionDetails.thresholdIndicator',
    reportingEntityTransactionReference NVARCHAR(255) '$.largeCashTransactionDetails.reportingEntityTransactionReference',
    dateTimeOfTransaction DATETIME '$.largeCashTransactionDetails.dateTimeOfTransaction',
    methodCode INT '$.largeCashTransactionDetails.methodCode',
    amount MONEY '$.startingActions[0].details.amount',
    currencyCode NVARCHAR(10) '$.startingActions[0].details.currencyCode',
    conductorTypeCode INT '$.startingActions[0].conductors[0].typeCode',
    conductorRefId NVARCHAR(255) '$.startingActions[0].conductors[0].refId',
    dispositionCode INT '$.completingActions[0].details.dispositionCode'
)
