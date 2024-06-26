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

Public Enum VirtualCurrencyCode
    <EnumMember(Value:="1inch Network (1INCH)")> _1INCH
    <EnumMember(Value:="Aave (AAVE)")> AAVE
    <EnumMember(Value:="ABBC Coin (ABBC)")> ABBC
    <EnumMember(Value:="Cardano (ADA)")> ADA
    <EnumMember(Value:="AdEx Network (ADX)")> ADX
    <EnumMember(Value:="Aeternity (AE)")> AE
    <EnumMember(Value:="Aergo (AERGO)")> AERGO
    <EnumMember(Value:="SingularityNET (AGI)")> AGI
    <EnumMember(Value:="AgaveCoin (AGVC)")> AGVC
    <EnumMember(Value:="Advanced Internet Blocks (AIB)")> AIB
    <EnumMember(Value:="Aion (AION)")> AION
    <EnumMember(Value:="Akropolis (AKRO)")> AKRO
    <EnumMember(Value:="Algorand (ALGO)")> ALGO
    <EnumMember(Value:="AMO Coin (AMO)")> AMO
    <EnumMember(Value:="Amp (AMP)")> AMP
    <EnumMember(Value:="Ampleforth (AMPL)")> AMPL
    <EnumMember(Value:="Anchor Protocol (ANC)")> ANC
    <EnumMember(Value:="Anchor (ANCT)")> ANCT
    <EnumMember(Value:="Ankr (ANKR)")> ANKR
    <EnumMember(Value:="Aragon (ANT)")> ANT
    <EnumMember(Value:="Aurora (AOA)")> AOA
    <EnumMember(Value:="Apollo Currency (APL)")> APL
    <EnumMember(Value:="apM Coin (APM)")> APM
    <EnumMember(Value:="Arweave (AR)")> AR
    <EnumMember(Value:="Ardor (ARDR)")> ARDR
    <EnumMember(Value:="Ark (ARK)")> ARK
    <EnumMember(Value:="ARPA Chain (ARPA)")> ARPA
    <EnumMember(Value:="Pirate Chain (ARRR)")> ARRR
    <EnumMember(Value:="AirSwap (AST)")> AST
    <EnumMember(Value:="Cosmos (ATOM)")> ATOM
    <EnumMember(Value:="Attila (ATT)")> ATT
    <EnumMember(Value:="Audius (AUDIO)")> AUDIO
    <EnumMember(Value:="Travala.com (AVA)")> AVA
    <EnumMember(Value:="Avalanche (AVAX)")> AVAX
    <EnumMember(Value:="AXIA Coin (AXC)")> AXC
    <EnumMember(Value:="AXEL (AXEL)")> AXEL
    <EnumMember(Value:="Axie Infinity (AXS)")> AXS
    <EnumMember(Value:="B2BX (B2B)")> B2B
    <EnumMember(Value:="Balancer (BAL)")> BAL
    <EnumMember(Value:="Band Protocol (BAND)")> BAND
    <EnumMember(Value:="BASIC (BASIC)")> BASIC
    <EnumMember(Value:="Basid Coin (BASID)")> BASID
    <EnumMember(Value:="Basic Attention Token (BAT)")> BAT
    <EnumMember(Value:="Bitcoin Diamond (BCD)")> BCD
    <EnumMember(Value:="Bitcoin Cash (BCH)")> BCH
    <EnumMember(Value:="Bytecoin (BCN)")> BCN
    <EnumMember(Value:="Buggyra Coin Zero (BCZERO)")> BCZERO
    <EnumMember(Value:="BDCC Bitica COIN (BDCC)")> BDCC
    <EnumMember(Value:="Beldex (BDX)")> BDX
    <EnumMember(Value:="Beam (BEAM)")> BEAM
    <EnumMember(Value:="Bella Protocol (BEL)")> BEL
    <EnumMember(Value:="Bithao (BHAO)")> BHAO
    <EnumMember(Value:="BitcoinHD (BHD)")> BHD
    <EnumMember(Value:="BHPCoin (BHP)")> BHP
    <EnumMember(Value:="BHEX Token (BHT)")> BHT
    <EnumMember(Value:="Biconomy (BICO)")> BICO
    <EnumMember(Value:="BigONE Token (ONE)")> BIGONE
    <EnumMember(Value:="BIKI (BIKI)")> BIKI
    <EnumMember(Value:="Bloomzed Loyalty Club Ticket (BLCT)")> BLCT
    <EnumMember(Value:="Blocknet (BLOCK)")> BLOCK
    <EnumMember(Value:="Bluzelle (BLZ)")> BLZ
    <EnumMember(Value:="Chimpion (BNANA)")> BNANA
    <EnumMember(Value:="Binance Coin (BNB)")> BNB
    <EnumMember(Value:="Bankera (BNK)")> BNK
    <EnumMember(Value:="Bancor (BNT)")> BNT
    <EnumMember(Value:="BOSAGORA (BOA)")> BOA
    <EnumMember(Value:="Bonorum (BONO)")> BONO
    <EnumMember(Value:="BORA (BORA)")> BORA
    <EnumMember(Value:="Bounce Token (BOT)")> BOT
    <EnumMember(Value:="botXcoin (BOTX)")> BOTX
    <EnumMember(Value:="BitcoinPoS (BPS)")> BPS
    <EnumMember(Value:="Baer Chain (BRC)")> BRC
    <EnumMember(Value:="Bridge Oracle (BRG)")> BRG
    <EnumMember(Value:="Breezecoin (BRZE)")> BRZE
    <EnumMember(Value:="Bitcoin SV (BSV)")> BSV
    <EnumMember(Value:="Bitcoin (BTC)")> BTC
    <EnumMember(Value:="Bitcoin 2 (BTC2)")> BTC2
    <EnumMember(Value:="Bitcoin BEP2 (BTCB)")> BTCB
    <EnumMember(Value:="Bitcoin Gold (BTG)")> BTG
    <EnumMember(Value:="Bytom (BTM)")> BTM
    <EnumMember(Value:="BitMax Token (BTMX)")> BTMX
    <EnumMember(Value:="Bitball Treasure (BTRS)")> BTRS
    <EnumMember(Value:="BitShares (BTS)")> BTS
    <EnumMember(Value:="BitTorrent (BTT)")> BTT
    <EnumMember(Value:="BTU Protocol (BTU)")> BTU
    <EnumMember(Value:="Binance USD (BUSD)")> BUSD
    <EnumMember(Value:="Beowulf (BWF)")> BWF
    <EnumMember(Value:="Bitbook Gambling (BXK)")> BXK
    <EnumMember(Value:="Bit-Z Token (BZ)")> BZ
    <EnumMember(Value:="bZx Protocol (BZRX)")> BZRX
    <EnumMember(Value:="CRYPTO20 (C20)")> C20
    <EnumMember(Value:="CAD Coin (CADC)")> CADC
    <EnumMember(Value:="PancakeSwap (CAKE)")> CAKE
    <EnumMember(Value:="Counos Coin (CCA)")> CCA
    <EnumMember(Value:="Counos X (CCXX)")> CCXX
    <EnumMember(Value:="Celsius (CEL)")> CEL
    <EnumMember(Value:="Celo (CELO)")> CELO
    <EnumMember(Value:="Celer Network (CELR)")> CELR
    <EnumMember(Value:="Centrality (CENNZ)")> CENNZ
    <EnumMember(Value:="Chromia (CHR)")> CHR
    <EnumMember(Value:="SwissBorg (CHSB)")> CHSB
    <EnumMember(Value:="Chiliz (CHZ)")> CHZ
    <EnumMember(Value:="Cipher Core Token (CIPHC)")> CIPHC
    <EnumMember(Value:="Cryptoindex.com 100 (CIX100)")> CIX100
    <EnumMember(Value:="Nervos Network (CKB)")> CKB
    <EnumMember(Value:="Cindicator (CND)")> CND
    <EnumMember(Value:="Cryptonex (CNX)")> CNX
    <EnumMember(Value:="Cocos-BCX (COCOS)")> COCOS
    <EnumMember(Value:="Compound (COMP)")> COMP
    <EnumMember(Value:="CONUN (CON)")> CON
    <EnumMember(Value:="cVault.finance (CORE)")> CORE
    <EnumMember(Value:="Contentos (COS)")> COS
    <EnumMember(Value:="COTI (COTI)")> COTI
    <EnumMember(Value:="Carry (CRE)")> CRE
    <EnumMember(Value:="Crypto.com Coin (CRO)")> CRO
    <EnumMember(Value:="Crypterium (CRPT)")> CRPT
    <EnumMember(Value:="Curve DAO Token (CRV)")> CRV
    <EnumMember(Value:="Creditcoin (CTC)")> CTC
    <EnumMember(Value:="CONTRACOIN (CTCN)")> CTCN
    <EnumMember(Value:="CertiK (CTK)")> CTK
    <EnumMember(Value:="Cartesi (CTSI)")> CTSI
    <EnumMember(Value:="Cortex (CTXC)")> CTXC
    <EnumMember(Value:="Celo Dollar (CUSD)")> CUSD
    <EnumMember(Value:="Crypto Village Accelerator (CVA)")> CVA
    <EnumMember(Value:="Civic (CVC)")> CVC
    <EnumMember(Value:="Content Value Network (CVNT)")> CVNT
    <EnumMember(Value:="CyberVein (CVT)")> CVT
    <EnumMember(Value:="Convex Finance (CVX)")> CVX
    <EnumMember(Value:="Davinci Coin (DAC)")> DAC
    <EnumMember(Value:="DAD (DAD)")> DAD
    <EnumMember(Value:="Constellation (DAG)")> DAG
    <EnumMember(Value:="Dai (DAI)")> DAI
    <EnumMember(Value:="Dash (DASH)")> DASH
    <EnumMember(Value:="Streamr (DATA)")> DATA
    <EnumMember(Value:="Decred (DCR)")> DCR
    <EnumMember(Value:="Dinastycoin (DCY)")> DCY
    <EnumMember(Value:="Darico Ecosystem Coin (DEC)")> DEC
    <EnumMember(Value:="Dent (DENT)")> DENT
    <EnumMember(Value:="DeFiChain (DFI)")> DFI
    <EnumMember(Value:="DigiByte (DGB)")> DGB
    <EnumMember(Value:="DigixDAO (DGD)")> DGD
    <EnumMember(Value:="Digitex Futures (DGTX)")> DGTX
    <EnumMember(Value:="DIA (DIA)")> DIA
    <EnumMember(Value:="Etherisc DIP Token (DIP)")> DIP
    <EnumMember(Value:="Divi (DIVI)")> DIVI
    <EnumMember(Value:="Darma Cash (DMCH)")> DMCH
    <EnumMember(Value:="DMM: Governance (DMG)")> DMG
    <EnumMember(Value:="Metaverse Dualchain Network Architecture (DNA)")> DNA
    <EnumMember(Value:="district0x (DNT)")> DNT
    <EnumMember(Value:="Dogecoin (DOGE)")> DOGE
    <EnumMember(Value:="Polkadot (DOT)")> DOT
    <EnumMember(Value:="DREP (DREP)")> DREP
    <EnumMember(Value:="Dragonchain (DRGN)")> DRGN
    <EnumMember(Value:="Doctors Coin (DRS)")> DRS
    <EnumMember(Value:="Dynamic Trading Rights (DTR)")> DTR
    <EnumMember(Value:="Dusk Network (DUSK)")> DUSK
    <EnumMember(Value:="DxChain Token (DX)")> DX
    <EnumMember(Value:="Ecoreal Estate (ECOREAL)")> ECOREAL
    <EnumMember(Value:="EDC Blockchain v1 [old] (EDC)")> EDC
    <EnumMember(Value:="Elrond (EGLD)")> EGLD
    <EnumMember(Value:="Elastos (ELA)")> ELA
    <EnumMember(Value:="aelf (ELF)")> ELF
    <EnumMember(Value:="Dogelon Mars (ELON)")> ELON
    <EnumMember(Value:="Einsteinium (EMC2)")> EMC2
    <EnumMember(Value:="Enigma (ENG)")> ENG
    <EnumMember(Value:="Enjin Coin (ENJ)")> ENJ
    <EnumMember(Value:="Ethereum Name Service (ENS)")> ENS
    <EnumMember(Value:="EOS (EOS)")> EOS
    <EnumMember(Value:="ERC20 (ERC20)")> ERC20
    <EnumMember(Value:="Ergo (ERG)")> ERG
    <EnumMember(Value:="Ethereum Classic (ETC)")> ETC
    <EnumMember(Value:="Ethereum (ETH)")> ETH
    <EnumMember(Value:="Electroneum (ETN)")> ETN
    <EnumMember(Value:="Elitium (EUM)")> EUM
    <EnumMember(Value:="STASIS EURO (EURS)")> EURS
    <EnumMember(Value:="Envion (EVN)")> EVN
    <EnumMember(Value:="Everus (EVR)")> EVR
    <EnumMember(Value:="Energy Web Token (EWT)")> EWT
    <EnumMember(Value:="FABRK (FAB)")> FAB
    <EnumMember(Value:="Harvest Finance (FARM)")> FARM
    <EnumMember(Value:="Fetch.ai (FET)")> FET
    <EnumMember(Value:="Filecoin (FIL)")> FIL
    <EnumMember(Value:="Folgory Coin (FLG)")> FLG
    <EnumMember(Value:="Flamingo (FLM)")> FLM
    <EnumMember(Value:="Flow (FLOW)")> FLOW
    <EnumMember(Value:="FNB Protocol (FNB)")> FNB
    <EnumMember(Value:="Fusion (FSN)")> FSN
    <EnumMember(Value:="1irstcoin (FST)")> FST
    <EnumMember(Value:="Fantom (FTM)")> FTM
    <EnumMember(Value:="FTX Token (FTT)")> FTT
    <EnumMember(Value:="FunFair (FUN)")> FUN
    <EnumMember(Value:="Function X (FX)")> FX
    <EnumMember(Value:="Flexacoin (FXC)")> FXC
    <EnumMember(Value:="Gala (GALA)")> GALA
    <EnumMember(Value:="Hashgard (GARD)")> GARD
    <EnumMember(Value:="Gas (GAS)")> GAS
    <EnumMember(Value:="Obyte (GBYTE)")> GBYTE
    <EnumMember(Value:="Gleec (GLEEC)")> GLEEC
    <EnumMember(Value:="Gnosis (GNO)")> GNO
    <EnumMember(Value:="Golem (GNT)")> GNT
    <EnumMember(Value:="Grin (GRIN)")> GRIN
    <EnumMember(Value:="GreenPower (GRN)")> GRN
    <EnumMember(Value:="Groestlcoin (GRS)")> GRS
    <EnumMember(Value:="The Graph (GRT)")> GRT
    <EnumMember(Value:="GateToken (GT)")> GT
    <EnumMember(Value:="Gemini Dollar (GUSD)")> GUSD
    <EnumMember(Value:="GXChain (GXC)")> GXC
    <EnumMember(Value:="Hedera Hashgraph (HBAR)")> HBAR
    <EnumMember(Value:="Huobi BTC (HBTC)")> HBTC
    <EnumMember(Value:="HyperCash (HC)")> HC
    <EnumMember(Value:="HedgeTrade (HEDG)")> HEDG
    <EnumMember(Value:="HEX (HEX)")> HEX
    <EnumMember(Value:="Hive (HIVE)")> HIVE
    <EnumMember(Value:="Homeros (HMR)")> HMR
    <EnumMember(Value:="Hellenic Coin (HNC)")> HNC
    <EnumMember(Value:="Handshake (HNS)")> HNS
    <EnumMember(Value:="Helium (HNT)")> HNT
    <EnumMember(Value:="HoDooi.com (HOD)")> HOD
    <EnumMember(Value:="Holo (HOT)")> HOT
    <EnumMember(Value:="Huobi Pool Token (HPT)")> HPT
    <EnumMember(Value:="Helper Search Token (HSN)")> HSN
    <EnumMember(Value:="Huobi Token (HT)")> HT
    <EnumMember(Value:="HUSD (HUSD)")> HUSD
    <EnumMember(Value:="Hxro (HXRO)")> HXRO
    <EnumMember(Value:="Hyperion (HYN)")> HYN
    <EnumMember(Value:="Idea Chain Coin (ICH)")> ICH
    <EnumMember(Value:="Internet Computer (ICP)")> ICP
    <EnumMember(Value:="ICON (ICX)")> ICX
    <EnumMember(Value:="IDEX (IDEX)")> IDEX
    <EnumMember(Value:="Ignis (IGNIS)")> IGNIS
    <EnumMember(Value:="Invictus Hyperion Fund (IHF)")> IHF
    <EnumMember(Value:="Illuvium (ILV)")> ILV
    <EnumMember(Value:="Immutable X (IMX)")> IMX
    <EnumMember(Value:="Insight Chain (INB)")> INB
    <EnumMember(Value:="Injective Protocol (INJ)")> INJ
    <EnumMember(Value:="INO COIN (INO)")> INO
    <EnumMember(Value:="Insights Network (INSTAR)")> INSTAR
    <EnumMember(Value:="IOST (IOST)")> IOST
    <EnumMember(Value:="IoTeX (IOTX)")> IOTX
    <EnumMember(Value:="Tachyon Protocol (IPX)")> IPX
    <EnumMember(Value:="Everipedia (IQ)")> IQ
    <EnumMember(Value:="IRISnet (IRIS)")> IRIS
    <EnumMember(Value:="IZE (IZE)")> IZE
    <EnumMember(Value:="JUST (JST)")> JST
    <EnumMember(Value:="Joule (JUL)")> JUL
    <EnumMember(Value:="Jewel (JWL)")> JWL
    <EnumMember(Value:="KardiaChain (KAI)")> KAI
    <EnumMember(Value:="BitKan (KAN)")> KAN
    <EnumMember(Value:="Kava.io (KAVA)")> KAVA
    <EnumMember(Value:="Karatgold Coin (KBC)")> KBC
    <EnumMember(Value:="Kcash (KCASH)")> KCASH
    <EnumMember(Value:="KuCoin Shares (KCS)")> KCS
    <EnumMember(Value:="Kadena (KDA)")> KDA
    <EnumMember(Value:="King DAG (KDAG)")> KDAG
    <EnumMember(Value:="Keep Network (KEEP)")> KEEP
    <EnumMember(Value:="Kin (KIN)")> KIN
    <EnumMember(Value:="Klaytn (KLAY)")> KLAY
    <EnumMember(Value:="Komodo (KMD)")> KMD
    <EnumMember(Value:="Kyber Network (KNC)")> KNC
    <EnumMember(Value:="Keep3rV1 (KP3R)")> KP3R
    <EnumMember(Value:="TerraKRW (KRT)")> KRT
    <EnumMember(Value:="Kusama (KSM)")> KSM
    <EnumMember(Value:="LATOKEN (LA)")> LA
    <EnumMember(Value:="Lambda (LAMB)")> LAMB
    <EnumMember(Value:="LBRY Credits (LBC)")> LBC
    <EnumMember(Value:="LCX (LCX)")> LCX
    <EnumMember(Value:="UNUS SED LEO (LEO)")> LEO
    <EnumMember(Value:="Levolution (LEVL)")> LEVL
    <EnumMember(Value:="Chainlink (LINK)")> LINK
    <EnumMember(Value:="Loki (LOKI)")> LOKI
    <EnumMember(Value:="Loom Network (LOOM)")> LOOM
    <EnumMember(Value:="Livepeer (LPT)")> LPT
    <EnumMember(Value:="Loopring (LRC)")> LRC
    <EnumMember(Value:="Largo Coin (LRG)")> LRG
    <EnumMember(Value:="Lisk (LSK)")> LSK
    <EnumMember(Value:="Litecoin (LTC)")> LTC
    <EnumMember(Value:="LTO Network (LTO)")> LTO
    <EnumMember(Value:="Terra (LUNA)")> LUNA
    <EnumMember(Value:="Level01 (LVX)")> LVX
    <EnumMember(Value:="MaidSafeCoin (MAID)")> MAID
    <EnumMember(Value:="Decentraland (MANA)")> MANA
    <EnumMember(Value:="Massnet (MASS)")> MASS
    <EnumMember(Value:="MATH (MATH)")> MATH
    <EnumMember(Value:="Matic Network (MATIC)")> MATIC
    <EnumMember(Value:="MovieBloc (MBL)")> MBL
    <EnumMember(Value:="Mobilian Coin (MBN)")> MBN
    <EnumMember(Value:="MCO (MCO)")> MCO
    <EnumMember(Value:="Moeda Loyalty Points (MDA)")> MDA
    <EnumMember(Value:="MediBloc (MED)")> MED
    <EnumMember(Value:="Mainframe (MFT)")> MFT
    <EnumMember(Value:="MINDOL (MIN)")> MIN
    <EnumMember(Value:="IOTA (MIOTA)")> MIOTA
    <EnumMember(Value:="Maker (MKR)")> MKR
    <EnumMember(Value:="MiL.k (MLK)")> MLK
    <EnumMember(Value:="Melon (MLN)")> MLN
    <EnumMember(Value:="Molecular Future (MOF)")> MOF
    <EnumMember(Value:="MonaCoin (MONA)")> MONA
    <EnumMember(Value:="Morpheus.Network (MRPH)")> MRPH
    <EnumMember(Value:="Meta (MTA)")> MTA
    <EnumMember(Value:="Metacoin (MTC)")> MTC
    <EnumMember(Value:="Metal (MTL)")> MTL
    <EnumMember(Value:="Tixl (MTXLT)")> MTXLT
    <EnumMember(Value:="mStable USD (MUSD)")> MUSD
    <EnumMember(Value:="MVL (MVL)")> MVL
    <EnumMember(Value:="MimbleWimbleCoin (MWC)")> MWC
    <EnumMember(Value:="MX Token (MX)")> MX
    <EnumMember(Value:="MXC (MXC)")> MXC
    <EnumMember(Value:="Nano (NANO)")> NANO
    <EnumMember(Value:="Nebulas (NAS)")> NAS
    <EnumMember(Value:="NEAR Protocol (NEAR)")> NEAR
    <EnumMember(Value:="Nectar (NEC)")> NEC
    <EnumMember(Value:="Neo (NEO)")> NEO
    <EnumMember(Value:="NEST Protocol (NEST)")> NEST
    <EnumMember(Value:="Nash Exchange (NEX)")> NEX
    <EnumMember(Value:="Nexo (NEXO)")> NEXO
    <EnumMember(Value:="Nexxo (NEXXO)")> NEXXO
    <EnumMember(Value:="Nimiq (NIM)")> NIM
    <EnumMember(Value:="NKN (NKN)")> NKN
    <EnumMember(Value:="Numeraire (NMR)")> NMR
    <EnumMember(Value:="NOIA Network (NOIA)")> NOIA
    <EnumMember(Value:="Pundi X (NPXS)")> NPXS
    <EnumMember(Value:="Energi (NRG)")> NRG
    <EnumMember(Value:="NuCypher (NU)")> NU
    <EnumMember(Value:="NULS (NULS)")> NULS
    <EnumMember(Value:="Native Utility Token (NUT)")> NUT
    <EnumMember(Value:="NerveNetwork (NVT)")> NVT
    <EnumMember(Value:="Newscrypto (NWC)")> NWC
    <EnumMember(Value:="NXM (NXM)")> NXM
    <EnumMember(Value:="Nexus (NXS)")> NXS
    <EnumMember(Value:="NewYork Exchange (NYE)")> NYE
    <EnumMember(Value:="Ocean Protocol (OCEAN)")> OCEAN
    <EnumMember(Value:="OctoFi (OCTO)")> OCTO
    <EnumMember(Value:="Origin Protocol (OGN)")> OGN
    <EnumMember(Value:="OKB (OKB)")> OKB
    <EnumMember(Value:="OMG Network (OMG)")> OMG
    <EnumMember(Value:="Harmony (ONE)")> ONE
    <EnumMember(Value:="ONOToken (ONOT)")> ONOT
    <EnumMember(Value:="Ontology (ONT)")> ONT
    <EnumMember(Value:="Orbs (ORBS)")> ORBS
    <EnumMember(Value:="Orbit Chain (ORC)")> ORC
    <EnumMember(Value:="Orion Protocol (ORN)")> ORN
    <EnumMember(Value:="Other / Fr-Other")> OTH
    <EnumMember(Value:="Orchid (OXT)")> OXT
    <EnumMember(Value:="Project Pai (PAI)")> PAI
    <EnumMember(Value:="Paxos Standard (PAX)")> PAX
    <EnumMember(Value:="PAX Gold (PAXG)")> PAXG
    <EnumMember(Value:="PeepCoin (PCN)")> PCN
    <EnumMember(Value:="ChainX (PCX)")> PCX
    <EnumMember(Value:="Perlin (PERL)")> PERL
    <EnumMember(Value:="Perpetual Protocol (PERP)")> PERP
    <EnumMember(Value:="Phala.Network (PHA)")> PHA
    <EnumMember(Value:="PIVX (PIVX)")> PIVX
    <EnumMember(Value:="PLATINCOIN (PLC)")> PLC
    <EnumMember(Value:="PlayFuel (PLF)")> PLF
    <EnumMember(Value:="Kleros (PNK)")> PNK
    <EnumMember(Value:="Polkastarter (POLS)")> POLS
    <EnumMember(Value:="Polymath (POLY)")> POLY
    <EnumMember(Value:="Power Ledger (POWR)")> POWR
    <EnumMember(Value:="Populous (PPT)")> PPT
    <EnumMember(Value:="Prometeus (PROM)")> PROM
    <EnumMember(Value:="PARSIQ (PRQ)")> PRQ
    <EnumMember(Value:="PRIZM (PZM)")> PZM
    <EnumMember(Value:="QASH (QASH)")> QASH
    <EnumMember(Value:="Qcash (QC)")> QC
    <EnumMember(Value:="QuarkChain (QKC)")> QKC
    <EnumMember(Value:="Quant (QNT)")> QNT
    <EnumMember(Value:="Poseidon Network (QQQ)")> QQQ
    <EnumMember(Value:="Quark (QRK)")> QRK
    <EnumMember(Value:="Quantum Resistant Ledger (QRL)")> QRL
    <EnumMember(Value:="Quantstamp (QSP)")> QSP
    <EnumMember(Value:="Qtum (QTUM)")> QTUM
    <EnumMember(Value:="RChain (REV)")> RCHAINREV
    <EnumMember(Value:="Ripio Credit Network (RCN)")> RCN
    <EnumMember(Value:="ReddCoin (RDD)")> RDD
    <EnumMember(Value:="Raiden Network Token (RDN)")> RDN
    <EnumMember(Value:="Ren (REN)")> REN
    <EnumMember(Value:="renBTC (RENBTC)")> RENBTC
    <EnumMember(Value:="Augur (REP)")> REP
    <EnumMember(Value:="REPO (REPO)")> REPO
    <EnumMember(Value:="Request (REQ)")> REQ
    <EnumMember(Value:="Revain (REV)")> REV
    <EnumMember(Value:="RSK Infrastructure Framework (RIF)")> RIF
    <EnumMember(Value:="Darwinia Network (RING)")> RING
    <EnumMember(Value:="Rakon (RKN)")> RKN
    <EnumMember(Value:="iExec RLC (RLC)")> RLC
    <EnumMember(Value:="Render Token (RNDR)")> RNDR
    <EnumMember(Value:="Oasis Network (ROSE)")> ROSE
    <EnumMember(Value:="Rocket Pool (RPL)")> RPL
    <EnumMember(Value:="Reserve Rights (RSR)")> RSR
    <EnumMember(Value:="THORChain (RUNE)")> RUNE
    <EnumMember(Value:="Ravencoin (RVN)")> RVN
    <EnumMember(Value:="S4FE (S4F)")> S4F
    <EnumMember(Value:="yieldfarming.insure (SAFE)")> SAFE
    <EnumMember(Value:="The Sandbox (SAND)")> SAND
    <EnumMember(Value:="Sapphire (SAPP)")> SAPP
    <EnumMember(Value:="Siacoin (SC)")> SC
    <EnumMember(Value:="STEM CELL COIN (SCC)")> SCC
    <EnumMember(Value:="Secret (SCRT)")> SCRT
    <EnumMember(Value:="Seele-N (SEELE)")> SEELE
    <EnumMember(Value:="Super Zero Protocol (SERO)")> SERO
    <EnumMember(Value:="SafePal (SFP)")> SFP
    <EnumMember(Value:="Shiba Inu (SHIB)")> SHIB
    <EnumMember(Value:="SHPING (SHPING)")> SHPING
    <EnumMember(Value:="ShareToken (SHR)")> SHR
    <EnumMember(Value:="SaluS (SLS)")> SLS
    <EnumMember(Value:="SynchroBitcoin (SNB)")> SNB
    <EnumMember(Value:="Sport and Leisure (SNL)")> SNL
    <EnumMember(Value:="Status (SNT)")> SNT
    <EnumMember(Value:="Sentivate (SNTVT)")> SNTVT
    <EnumMember(Value:="Synthetix (SNX)")> SNX
    <EnumMember(Value:="Solana (SOL)")> SOL
    <EnumMember(Value:="Sologenic (SOLO)")> SOLO
    <EnumMember(Value:="SOLVE (SOLVE)")> SOLVE
    <EnumMember(Value:="Spendcoin (SPND)")> SPND
    <EnumMember(Value:="Serum (SRM)")> SRM
    <EnumMember(Value:="xDai (STAKE)")> STAKE
    <EnumMember(Value:="Steem (STEEM)")> STEEM
    <EnumMember(Value:="StormX (STMX)")> STMX
    <EnumMember(Value:="Storj (STORJ)")> STORJ
    <EnumMember(Value:="STPAY (STP)")> STP
    <EnumMember(Value:="Standard Tokenization Protocol (STPT)")> STPT
    <EnumMember(Value:="Stratis (STRAT)")> STRAT
    <EnumMember(Value:="Strong (STRONG)")> STRONG
    <EnumMember(Value:="Blockstack (STX)")> STX
    <EnumMember(Value:="SUKU (SUKU)")> SUKU
    <EnumMember(Value:="SUN (SUN)")> SUN
    <EnumMember(Value:="sUSD (SUSD)")> SUSD
    <EnumMember(Value:="SushiSwap (SUSHI)")> SUSHI
    <EnumMember(Value:="TrustSwap (SWAP)")> SWAP
    <EnumMember(Value:="Swingby (SWINGBY)")> SWINGBY
    <EnumMember(Value:="Switcheo (SWTH)")> SWTH
    <EnumMember(Value:="Swipe (SXP)")> SXP
    <EnumMember(Value:="Syscoin (SYS)")> SYS
    <EnumMember(Value:="TrueCAD (TCAD)")> TCAD
    <EnumMember(Value:="Telcoin (TEL)")> TEL
    <EnumMember(Value:="Theta Fuel (TFUEL)")> TFUEL
    <EnumMember(Value:="THETA (THETA)")> THETA
    <EnumMember(Value:="ThoreCoin (THR)")> THR
    <EnumMember(Value:="ThoreNext (THX)")> THX
    <EnumMember(Value:="TitanSwap (TITAN)")> TITAN
    <EnumMember(Value:="The Midas Touch Gold (TMTG)")> TMTG
    <EnumMember(Value:="TNC Coin (TNC)")> TNC
    <EnumMember(Value:="TomoChain (TOMO)")> TOMO
    <EnumMember(Value:="Tectonic (TONIC)")> TONIC
    <EnumMember(Value:="OriginTrail (TRAC)")> TRAC
    <EnumMember(Value:="Tratin (TRAT)")> TRAT
    <EnumMember(Value:="Tellor (TRB)")> TRB
    <EnumMember(Value:="TROY (TROY)")> TROY
    <EnumMember(Value:="TrueChain (TRUE)")> [TRUE]
    <EnumMember(Value:="TRON (TRX)")> TRX
    <EnumMember(Value:="12Ships (TSHP)")> TSHP
    <EnumMember(Value:="Thunder Token (TT)")> TT
    <EnumMember(Value:="The Transfer Token (TTT)")> TTT
    <EnumMember(Value:="TrueUSD (TUSD)")> TUSD
    <EnumMember(Value:="Trust Wallet Token (TWT)")> TWT
    <EnumMember(Value:="Unibright (UBT)")> UBT
    <EnumMember(Value:="Ultiledger (ULT)")> ULT
    <EnumMember(Value:="UMA (UMA)")> UMA
    <EnumMember(Value:="Uniswap (UNI)")> UNI
    <EnumMember(Value:="UNI COIN (UNICOIN)")> UNICOIN
    <EnumMember(Value:="Unobtanium (UNO)")> UNO
    <EnumMember(Value:="Ultra (UOS)")> UOS
    <EnumMember(Value:="Uquid Coin (UQC)")> UQC
    <EnumMember(Value:="USD Coin (USDC)")> USDC
    <EnumMember(Value:="USDJ (USDJ)")> USDJ
    <EnumMember(Value:="USDK (USDK)")> USDK
    <EnumMember(Value:="Neutrino USD (USDN)")> USDN
    <EnumMember(Value:="Pax Dollar (USDP)")> USDP
    <EnumMember(Value:="Tether (USDT)")> USDT
    <EnumMember(Value:="TerraUSD (UST)")> UST
    <EnumMember(Value:="Utrust (UTK)")> UTK
    <EnumMember(Value:="VestChain (VEST)")> VEST
    <EnumMember(Value:="VeChain (VET)")> VET
    <EnumMember(Value:="Voyager Token (VGX)")> VGX
    <EnumMember(Value:="VIDT Datalink (VIDT)")> VIDT
    <EnumMember(Value:="Vitae (VITAE)")> VITAE
    <EnumMember(Value:="Velas (VLX)")> VLX
    <EnumMember(Value:="VerusCoin (VRSC)")> VRSC
    <EnumMember(Value:="v.systems (VSYS)")> VSYS
    <EnumMember(Value:="VeThor Token (VTHO)")> VTHO
    <EnumMember(Value:="VVS Finance (VVS)")> VVS
    <EnumMember(Value:="Wanchain (WAN)")> WAN
    <EnumMember(Value:="Waves (WAVES)")> WAVES
    <EnumMember(Value:="WAX (WAXP)")> WAXP
    <EnumMember(Value:="Wrapped BNB (WBNB)")> WBNB
    <EnumMember(Value:="Wrapped Bitcoin (WBTC)")> WBTC
    <EnumMember(Value:="WeShow Token (WET)")> WET
    <EnumMember(Value:="WaykiChain (WICC)")> WICC
    <EnumMember(Value:="WINk (WIN)")> WIN
    <EnumMember(Value:="Wixlar (WIX)")> WIX
    <EnumMember(Value:="WOM Protocol (WOM)")> WOM
    <EnumMember(Value:="WazirX (WRX)")> WRX
    <EnumMember(Value:="Waltonchain (WTC)")> WTC
    <EnumMember(Value:="Wirex Token (WXT)")> WXT
    <EnumMember(Value:="CoinMetro Token (XCM)")> XCM
    <EnumMember(Value:="XinFin Network (XDC)")> XDC
    <EnumMember(Value:="eCash (XEC)")> XEC
    <EnumMember(Value:="NEM (XEM)")> XEM
    <EnumMember(Value:="Haven Protocol (XHV)")> XHV
    <EnumMember(Value:="Mixin (XIN)")> XIN
    <EnumMember(Value:="Stellar (XLM)")> XLM
    <EnumMember(Value:="Nexalt (XLT)")> XLT
    <EnumMember(Value:="Monero (XMR)")> XMR
    <EnumMember(Value:="XeniosCoin (XNC)")> XNC
    <EnumMember(Value:="Sora (XOR)")> XOR
    <EnumMember(Value:="Proton (XPR)")> XPR
    <EnumMember(Value:="XRP (XRP)")> XRP
    <EnumMember(Value:="Stakenet (XSN)")> XSN
    <EnumMember(Value:="Xensor (XSR)")> XSR
    <EnumMember(Value:="ExtStock Token (XT)")> XT
    <EnumMember(Value:="Tap (XTP)")> XTP
    <EnumMember(Value:="Tezos (XTZ)")> XTZ
    <EnumMember(Value:="Verge (XVG)")> XVG
    <EnumMember(Value:="Venus (XVS)")> XVS
    <EnumMember(Value:="WhiteCoin (XWC)")> XWC
    <EnumMember(Value:="Symbol (XYM)")> XYM
    <EnumMember(Value:="XYO (XYO)")> XYO
    <EnumMember(Value:="Zcoin (XZC)")> XZC
    <EnumMember(Value:="YEP COIN (YEP)")> YEP
    <EnumMember(Value:="YFDAI.FINANCE (YF-DAI)")> YF_DAI
    <EnumMember(Value:="yearn.finance (YFI)")> YFI
    <EnumMember(Value:="DFI.Money (YFII)")> YFII
    <EnumMember(Value:="YF Link (YFL)")> YFL
    <EnumMember(Value:="Yield Guild Games (YGG)")> YGG
    <EnumMember(Value:="YUSRA (YUSRA)")> YUSRA
    <EnumMember(Value:="Zap (ZAP)")> ZAP
    <EnumMember(Value:="ZB Token (ZB)")> ZB
    <EnumMember(Value:="0Chain (ZCN)")> ZCN
    <EnumMember(Value:="Zcash (ZEC)")> ZEC
    <EnumMember(Value:="Horizen (ZEN)")> ZEN
    <EnumMember(Value:="Zilliqa (ZIL)")> ZIL
    <EnumMember(Value:="Zelwin (ZLW)")> ZLW
    <EnumMember(Value:="Zenon (ZNN)")> ZNN
    <EnumMember(Value:="0x (ZRX)")> ZRX
    <EnumMember(Value:="ZBG Token (ZT)")> ZT
    <EnumMember(Value:="Zynecoin (ZYN)")> ZYN
End Enum
