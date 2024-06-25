Imports System.Runtime.Serialization

Public Enum ReportTypeCode
    <EnumMember(Value:="Large Virtual Currency Transaction Report (LVCTR)")> LVCTR = 14
    <EnumMember(Value:="Suspicious transaction report (STR)")> STR = 102
    <EnumMember(Value:="Large cash transaction report (LCTR)")> LCTR = 106
    <EnumMember(Value:="Casino disbursement report (CDR)")> CDR = 113
    <EnumMember(Value:="Electronic funds transfer report (EFTR)")> EFTR = 145
End Enum

Public Enum SubmitTypeCode
    <EnumMember(Value:="Submit")> Submit = 1
    <EnumMember(Value:="Update")> Update = 2
    <EnumMember(Value:="Delete")> Delete = 5
End Enum

Public Enum ActivitySectorCode
    <EnumMember(Value:="Accountant")> Accountant = 1
    <EnumMember(Value:="Bank")> Bank = 2
    <EnumMember(Value:="Caisse populaire")> CaissePopulaire = 3
    <EnumMember(Value:="Crown agent")> CrownAgent = 4
    <EnumMember(Value:="Casino")> Casino = 5
    <EnumMember(Value:="Co-op credit society")> CoopCreditSociety = 6
    <EnumMember(Value:="Life insurance broker or agent")> LifeInsuranceBrokerOrAgent = 9
    <EnumMember(Value:="Life insurance company")> LifeInsuranceCompany = 10
    <EnumMember(Value:="Money services business")> MoneyServicesBusiness = 11
    <EnumMember(Value:="Provincial savings office")> ProvincialSavingsOffice = 12
    <EnumMember(Value:="Real estate")> RealEstate = 13
    <EnumMember(Value:="Credit union")> CreditUnion = 14
    <EnumMember(Value:="Securities dealer")> SecuritiesDealer = 15
    <EnumMember(Value:="Trust and/or loan company")> TrustOrLoanCompany = 16
    <EnumMember(Value:="British Columbia notary")> BCNotary = 17
    <EnumMember(Value:="Dealer in precious metals and stones")> DealerInPreciousMetalsAndStones = 18
    <EnumMember(Value:="Credit union central")> CreditUnionCentral = 19
    <EnumMember(Value:="Financial services cooperative")> FinancialServicesCooperative = 20
    <EnumMember(Value:="Foreign money services business")> ForeignMoneyServicesBusiness = 21
End Enum

Public Enum AggregationTypeCode
    <EnumMember(Value:="Beneficiary")> Beneficiary = 1
    <EnumMember(Value:="Conductor")> Conductor = 2
    <EnumMember(Value:="On behalf of (i.e. 3rd party)")> OnBehalfOf = 3
    <EnumMember(Value:="Not applicable")> NotApplicable = 4
End Enum

Public Enum EftrAggregationTypeCode
    <EnumMember(Value:="Beneficiary")> Beneficiary = 1
    <EnumMember(Value:="On behalf of (i.e. 3rd party)")> OnBehalfOf = 3
    <EnumMember(Value:="Not applicable")> NotApplicable = 4
    <EnumMember(Value:="Requester")> Requester = 5
End Enum

Public Enum CdrAggregationTypeCode
    <EnumMember(Value:="Not applicable")> NotApplicable = 4
    <EnumMember(Value:="Received by")> ReceivedBy = 6
    <EnumMember(Value:="Received on behalf of")> ReceivedOnBehalfOf = 7
    <EnumMember(Value:="Requested by")> RequestedBy = 8
    <EnumMember(Value:="Requested on behalf of")> RequestedOnBehalfOf = 9
End Enum

Public Enum MinisterialDirectiveCode
    <EnumMember(Value:="IR2020")> IR2020 = 1
End Enum

Public Enum StructureTypeCode
    <EnumMember(Value:="Corporation")> Corporation = 1
    <EnumMember(Value:="Entity other than a corporation or trust")> EntityOtherThanCorporationOrTrust = 2
    <EnumMember(Value:="Trust")> Trust = 3
    <EnumMember(Value:="Widely held or publicly traded trust")> PubliclyTradedTrust = 4
End Enum

Public Enum AccountTypeCode
    <EnumMember(Value:="Personal")> Personal = 1
    <EnumMember(Value:="Business")> Business = 2
    <EnumMember(Value:="Trust")> Trust = 3
    <Enum
