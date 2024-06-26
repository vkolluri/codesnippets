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
    <EnumMember(Value:="Other")> Other = 4
    <EnumMember(Value:="Casino")> Casino = 5
End Enum

Public Enum IncorporationRegistrationTypeCode
    <EnumMember(Value:="Registered")> Registered = 1
    <EnumMember(Value:="Incorporated")> Incorporated = 2
    <EnumMember(Value:="Registered and incorporated")> RegisteredAndIncorporated = 4
    <EnumMember(Value:="Unknown")> Unknown = 5
End Enum

Public Enum AddressTypeCode
    <EnumMember(Value:="Structured address")> Structured = 1
    <EnumMember(Value:="Unstructured address")> Unstructured = 2
End Enum

Public Enum DefinitionType12
    <EnumMember(Value:="Person name")> PersonName = 1
    <EnumMember(Value:="Entity name")> EntityName = 2
End Enum

Public Enum DefinitionType34
    <EnumMember(Value:="Person details")> PersonDetails = 3
    <EnumMember(Value:="Entity details")> EntityDetails = 4
End Enum

Public Enum DefinitionType56
    <EnumMember(Value:="Person and employer Details")> PersonAndEmployerDetails = 5
    <EnumMember(Value:="Entity and beneficial ownership details")> EntityAndBeneficialOwnershipDetails = 6
End Enum

Public Enum DefinitionType78
    <EnumMember(Value:="Person name and address")> PersonNameAndAddress = 7
    <EnumMember(Value:="Entity name and address")> EntityNameAndAddress = 8
End Enum

Public Enum DefinitionType01278
    <EnumMember(Value:="Not applicable")> NotApplicable = 0
    <EnumMember(Value:="Person name")> PersonName = 1
    <EnumMember(Value:="Entity name")> EntityName = 2
    <EnumMember(Value:="Person name and address")> PersonNameAndAddress = 7
    <EnumMember(Value:="Entity name and address")> EntityNameAndAddress = 8
End Enum

Public Enum DefinitionType34910
    <EnumMember(Value:="Person details")> PersonDetails = 3
    <EnumMember(Value:="Entity details")> EntityDetails = 4
    <EnumMember(Value:="Person basic details")> PersonBasicDetails = 9
    <EnumMember(Value:="Entity basic details")> EntityBasicDetails = 10
End Enum

Public Enum AdditionalPaymentInformationTag
    <EnumMember(Value:="Remittance Information")> RemittanceInformation = 1
    <EnumMember(Value:="Instructed Amount")> InstructedAmount = 2
    <EnumMember(Value:="Charges Information")> ChargesInformation = 3
    <EnumMember(Value:="Payment Identification")> PaymentIdentification = 4
    <EnumMember(Value:="Payment Type Information")> PaymentTypeInformation = 5
    <EnumMember(Value:="Instruction For Creditor Agent")> InstructionForCreditorAgent = 6
    <EnumMember(Value:="Instruction For Next Agent")> InstructionForNextAgent = 7
    <EnumMember(Value:="Regulatory Reporting")> RegulatoryReporting = 8
    <EnumMember(Value:="Supplementary Data")> SupplementaryData = 9
    <EnumMember(Value:="Related Remittance Information")> RelatedRemittanceInformation = 10
    <EnumMember(Value:="Purpose")> Purpose = 11
End Enum

Public Enum OnBehalfOfRelationshipType
    <EnumMember(Value:="Accountant")> Accountant = 1
    <EnumMember(Value:="Agent")> Agent = 2
    <EnumMember(Value:="Borrower")> Borrower = 3
    <EnumMember(Value:="Broker")> Broker = 4
    <EnumMember(Value:="Customer")> Customer = 5
    <EnumMember(Value:="Employee")> Employee = 6
    <EnumMember(Value:="Friend")> Friend = 7
    <EnumMember(Value:="Relative")> Relative = 8
    <EnumMember(Value:="Other")> Other = 9
    <EnumMember(Value:="Legal counsel")> LegalCounsel = 10
    <EnumMember(Value:="Employer")> Employer = 11
    <EnumMember(Value:="Joint/Secondary owner")> JointSecondaryOwner = 12
    <EnumMember(Value:="Power of attorney")> PowerOfAttorney = 13
    <EnumMember(Value:="Vendor/Supplier")> VendorSupplier = 14
    <EnumMember(Value:="Authorized signatory")> AuthorizedSignatory = 16
End Enum

Public Enum InitiatorRelationshipType
    <EnumMember(Value:="Other")> Other = 9
    <EnumMember(Value:="Intermediary Institution")> IntermediaryInstitution = 17
    <EnumMember(Value:="Sending institution")> SendingInstitution = 18
    <EnumMember(Value:="Receiving institution")> ReceivingInstitution = 19
    <EnumMember(Value:="Debtors agent")> DebtorsAgent = 20
    <EnumMember(Value:="Creditors agent")> CreditorsAgent = 21
    <EnumMember(Value:="Instructing agent")> InstructingAgent = 22
    <EnumMember(Value:="Instructed agent")> InstructedAgent = 23
    <EnumMember(Value:="Intermediary agent 1")> IntermediaryAgent1 = 24
    <EnumMember(Value:="Intermediary agent 2")> IntermediaryAgent2 = 25
    <EnumMember(Value:="Intermediary agent 3")> IntermediaryAgent3 = 26
    <EnumMember(Value:="Previous instructing agent 1")> PreviousInstructingAgent1 = 27
    <EnumMember(Value:="Previous instructing agent 2")> PreviousInstructingAgent2 = 28
    <EnumMember(Value:="Previous instructing agent 3")> PreviousInstructingAgent3 = 29
    <EnumMember(Value:="Ordering institution")> OrderingInstitution = 30
    <EnumMember(Value:="Beneficiary institution")> BeneficiaryInstitution = 31
End Enum

Public Enum InvolvementRelationshipType
    <EnumMember(Value:="Other")> Other = 9
    <EnumMember(Value:="Sender's correspondent (MT-53a)")> SendersCorrespondent = 32
    <EnumMember(Value:="Receiver's correspondent (MT-54a)")> ReceiversCorrespondent = 33
    <EnumMember(Value:="Third reimbursement institution(MT-55a)")> ThirdReimbursementInstitution = 34
    <EnumMember(Value:="Instructing reimbursement agent")> InstructingReimbursementAgent = 35
    <EnumMember(Value:="Instructed reimbursement agent")> InstructedReimbursementAgent = 36
    <EnumMember(Value:="Third reimbursement agent")> ThirdReimbursementAgent = 37
    <EnumMember(Value:="Reimbursement agent 1")> ReimbursementAgent1 = 38
    <EnumMember(Value:="Reimbursement agent 2")> ReimbursementAgent2 = 39
    <EnumMember(Value:="Reimbursement agent 3")> ReimbursementAgent3 = 40
End Enum

Public Enum EftTypeCode
    <EnumMember(Value:="Swift")> Swift = 1
    <EnumMember(Value:="Non Swift")> NonSwift = 2
End Enum

Public Enum CanadianResidentStatus
    <EnumMember(Value:="In Canada")> InCanada = 1
    <EnumMember(Value:="Outside Canada")> OutsideCanada = 2
    <EnumMember(Value:="Not applicable")> NotApplicable = 3
End Enum

Public Enum TypeOfDeviceCode
    <EnumMember(Value:="Computer/Laptop")> ComputerLaptop = 1
    <EnumMember(Value:="Mobile phone")> MobilePhone = 2
    <EnumMember(Value:="Tablet")> Tablet = 3
    <EnumMember(Value:="Other")> Other = 4
End Enum

Public Enum RelationshipOfConductorCode
    <EnumMember(Value:="Accountant")> Accountant = 1
    <EnumMember(Value:="Agent")> Agent = 2
    <EnumMember(Value:="Borrower")> Borrower = 3
    <EnumMember(Value:="Broker")> Broker = 4
    <EnumMember(Value:="Customer")> Customer = 5
    <EnumMember(Value:="Employee")> Employee = 6
    <EnumMember(Value:="Friend")> Friend = 7
    <EnumMember(Value:="Relative")> Relative = 8
    <EnumMember(Value:="Other")> Other = 9
    <EnumMember(Value:="Legal counsel")> LegalCounsel = 10
    <EnumMember(Value:="Employer")> Employer = 11
    <EnumMember(Value:="Joint/Secondary owner")> JointSecondaryOwner = 12
    <EnumMember(Value:="Power of attorney")> PowerOfAttorney = 13
End Enum

Public Enum RelationshipOfConductorCodeWithVendor
    <EnumMember(Value:="Accountant")> Accountant = 1
    <EnumMember(Value:="Agent")> Agent = 2
    <EnumMember(Value:="Borrower")> Borrower = 3
    <EnumMember(Value:="Broker")> Broker = 4
    <EnumMember(Value:="Customer")> Customer = 5
    <EnumMember(Value:="Employee")> Employee = 6
    <EnumMember(Value:="Friend")> Friend = 7
    <EnumMember(Value:="Relative")> Relative = 8
    <EnumMember(Value:="Other")> Other = 9
    <EnumMember(Value:="Legal counsel")> LegalCounsel = 10
    <EnumMember(Value:="Employer")> Employer = 11
    <EnumMember(Value:="Joint/Secondary owner")> JointSecondaryOwner = 12
    <EnumMember(Value:="Power of attorney")> PowerOfAttorney = 13
    <EnumMember(Value:="Vendor/Supplier")> VendorSupplier = 14
End Enum

Public Enum RelationshipOfConductorCodeWithSelf
    <EnumMember(Value:="Accountant")> Accountant = 1
    <EnumMember(Value:="Agent")> Agent = 2
    <EnumMember(Value:="Borrower")> Borrower = 3
    <EnumMember(Value:="Broker")> Broker = 4
    <EnumMember(Value:="Customer")> Customer = 5
    <EnumMember(Value:="Employee")> Employee = 6
    <EnumMember(Value:="Friend")> Friend = 7
    <EnumMember(Value:="Relative")> Relative = 8
    <EnumMember(Value:="Other")> Other = 9
    <EnumMember(Value:="Legal counsel")> LegalCounsel = 10
    <EnumMember(Value:="Employer")> Employer = 11
    <EnumMember(Value:="Joint/Secondary owner")> JointSecondaryOwner = 12
    <EnumMember(Value:="Power of attorney")> PowerOfAttorney = 13
    <EnumMember(Value:="Vendor/Supplier")> VendorSupplier = 14
    <EnumMember(Value:="Self")> Self = 15
End Enum

Public Enum AccountStatusAtTimeOfTransaction
    <EnumMember(Value:="Active")> Active = 1
    <EnumMember(Value:="Inactive")> Inactive = 2
    <EnumMember(Value:="Dormant")> Dormant = 3
    <EnumMember(Value:="Closed")> Closed = 4
End Enum
