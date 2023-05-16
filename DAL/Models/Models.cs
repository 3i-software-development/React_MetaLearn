using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class Models : DbContext
{
    public Models()
    {
    }

    public Models(DbContextOptions<Models> options)
        : base(options)
    {
    }

    /*public virtual DbSet<ActInstanceUserActivity> ActInstanceUserActivities { get; set; }

    public virtual DbSet<Activity> Activities { get; set; }*/

    public virtual DbSet<ActivityAttrDatum> ActivityAttrData { get; set; }

    /*public virtual DbSet<ActivityAttrSetup> ActivityAttrSetups { get; set; }

    public virtual DbSet<ActivityFile> ActivityFiles { get; set; }*/

    public virtual DbSet<ActivityInstFile> ActivityInstFiles { get; set; }

    /*public virtual DbSet<ActivityInstance> ActivityInstances { get; set; }*/

    public virtual DbSet<ActivityInstanceLogDatum> ActivityInstanceLogData { get; set; }

    /*public virtual DbSet<ActivityInstanceObjective> ActivityInstanceObjectives { get; set; }*/

    public virtual DbSet<ActivityLogDatum> ActivityLogData { get; set; }

    public virtual DbSet<ActivityTransition> ActivityTransitions { get; set; }

    public virtual DbSet<ActivityWorkflow> ActivityWorkflows { get; set; }

    public virtual DbSet<AdAccessLog> AdAccessLogs { get; set; }

    public virtual DbSet<AdActionLog> AdActionLogs { get; set; }

    public virtual DbSet<AdAppFunction> AdAppFunctions { get; set; }

    public virtual DbSet<AdApplication> AdApplications { get; set; }

    public virtual DbSet<AdAuthoring> AdAuthorings { get; set; }

    public virtual DbSet<AdDepartment> AdDepartments { get; set; }

    public virtual DbSet<AdDivision> AdDivisions { get; set; }

    public virtual DbSet<AdDivisionCopy> AdDivisionCopies { get; set; }

    public virtual DbSet<AdFunction> AdFunctions { get; set; }

    public virtual DbSet<AdFunctionBackUp> AdFunctionBackUps { get; set; }

    public virtual DbSet<AdGroupUser> AdGroupUsers { get; set; }

    public virtual DbSet<AdLanguage> AdLanguages { get; set; }

    public virtual DbSet<AdLanguageText> AdLanguageTexts { get; set; }

    public virtual DbSet<AdOrganization> AdOrganizations { get; set; }

    public virtual DbSet<AdParameter> AdParameters { get; set; }

    public virtual DbSet<AdPermission> AdPermissions { get; set; }

    public virtual DbSet<AdPrivilege> AdPrivileges { get; set; }

    public virtual DbSet<AdPrivilegeBackUp> AdPrivilegeBackUps { get; set; }

    public virtual DbSet<AdResource> AdResources { get; set; }

    public virtual DbSet<AdResourceBack02112020> AdResourceBack02112020s { get; set; }

    public virtual DbSet<AdResourceBackUp> AdResourceBackUps { get; set; }

    public virtual DbSet<AdUserDepartment> AdUserDepartments { get; set; }

    public virtual DbSet<AdUserInGroup> AdUserInGroups { get; set; }

    public virtual DbSet<AddonApp> AddonApps { get; set; }

    public virtual DbSet<AddonAppServer> AddonAppServers { get; set; }

    public virtual DbSet<AllowanceCat> AllowanceCats { get; set; }

    public virtual DbSet<AllowanceEmployeeAccept> AllowanceEmployeeAccepts { get; set; }

    public virtual DbSet<AllowanceEmployeeMonth> AllowanceEmployeeMonths { get; set; }

    public virtual DbSet<AllowanceEmployeeParam> AllowanceEmployeeParams { get; set; }

    public virtual DbSet<AllowanceParam> AllowanceParams { get; set; }

    public virtual DbSet<AppMeeting> AppMeetings { get; set; }

    public virtual DbSet<AppVendor> AppVendors { get; set; }

    public virtual DbSet<AseanDocument> AseanDocuments { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<AspNetUsersTest> AspNetUsersTests { get; set; }

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<AssetActivity> AssetActivities { get; set; }

    /*public virtual DbSet<AssetAllocateDetail> AssetAllocateDetails { get; set; }*/

    public virtual DbSet<AssetAllocateFile> AssetAllocateFiles { get; set; }

    /*public virtual DbSet<AssetAllocateHeader> AssetAllocateHeaders { get; set; }

    public virtual DbSet<AssetAttrGalaxy> AssetAttrGalaxies { get; set; }

    public virtual DbSet<AssetAttribute> AssetAttributes { get; set; }

    public virtual DbSet<AssetBuyDetail> AssetBuyDetails { get; set; }

    public virtual DbSet<AssetBuyFile> AssetBuyFiles { get; set; }

    public virtual DbSet<AssetBuyHeader> AssetBuyHeaders { get; set; }

    public virtual DbSet<AssetCancelDetail> AssetCancelDetails { get; set; }

    public virtual DbSet<AssetCancelFile> AssetCancelFiles { get; set; }

    public virtual DbSet<AssetCancelHeader> AssetCancelHeaders { get; set; }*/

    /*public virtual DbSet<AssetEntityMapping> AssetEntityMappings { get; set; }

    public virtual DbSet<AssetGroup> AssetGroups { get; set; }

    public virtual DbSet<AssetImprovementCategory> AssetImprovementCategories { get; set; }*/

    public virtual DbSet<AssetImprovementDetail> AssetImprovementDetails { get; set; }

    /*public virtual DbSet<AssetImprovementFile> AssetImprovementFiles { get; set; }*/

    public virtual DbSet<AssetImprovementHeader> AssetImprovementHeaders { get; set; }

    public virtual DbSet<AssetInventoryDetail> AssetInventoryDetails { get; set; }

    public virtual DbSet<AssetInventoryFile> AssetInventoryFiles { get; set; }

    public virtual DbSet<AssetInventoryHeader> AssetInventoryHeaders { get; set; }

    public virtual DbSet<AssetLiquidationDetail> AssetLiquidationDetails { get; set; }

    public virtual DbSet<AssetLiquidationFile> AssetLiquidationFiles { get; set; }

    public virtual DbSet<AssetLiquidationHeader> AssetLiquidationHeaders { get; set; }

    public virtual DbSet<AssetMain> AssetMains { get; set; }

    public virtual DbSet<AssetMaintenanceCategory> AssetMaintenanceCategories { get; set; }

    public virtual DbSet<AssetMaintenanceDetail> AssetMaintenanceDetails { get; set; }

    public virtual DbSet<AssetMaintenanceFile> AssetMaintenanceFiles { get; set; }

    public virtual DbSet<AssetMaintenanceHeader> AssetMaintenanceHeaders { get; set; }

    public virtual DbSet<AssetRecalledDetail> AssetRecalledDetails { get; set; }

    public virtual DbSet<AssetRecalledFile> AssetRecalledFiles { get; set; }

    public virtual DbSet<AssetRecalledHeader> AssetRecalledHeaders { get; set; }

    public virtual DbSet<AssetRecordDeliveryDetail> AssetRecordDeliveryDetails { get; set; }

    public virtual DbSet<AssetRecordDeliveryHeader> AssetRecordDeliveryHeaders { get; set; }

    public virtual DbSet<AssetRecordsPack> AssetRecordsPacks { get; set; }

    public virtual DbSet<AssetRecordsPackAttr> AssetRecordsPackAttrs { get; set; }

    public virtual DbSet<AssetRecordsPackFile> AssetRecordsPackFiles { get; set; }

    public virtual DbSet<AssetReqMaintainceReparrDetail> AssetReqMaintainceReparrDetails { get; set; }

    public virtual DbSet<AssetReqMaintainceReparrFile> AssetReqMaintainceReparrFiles { get; set; }

    public virtual DbSet<AssetReqMaintainceReparrHeader> AssetReqMaintainceReparrHeaders { get; set; }

    public virtual DbSet<AssetRptBrokenDetail> AssetRptBrokenDetails { get; set; }

    public virtual DbSet<AssetRptBrokenFile> AssetRptBrokenFiles { get; set; }

    public virtual DbSet<AssetRptBrokenHeader> AssetRptBrokenHeaders { get; set; }

    public virtual DbSet<AssetTransferDetail> AssetTransferDetails { get; set; }

    public virtual DbSet<AssetTransferFile> AssetTransferFiles { get; set; }

    public virtual DbSet<AssetTransferHeader> AssetTransferHeaders { get; set; }

    public virtual DbSet<AssetType> AssetTypes { get; set; }

    public virtual DbSet<AssetZoneAttr> AssetZoneAttrs { get; set; }

    public virtual DbSet<AssetZoneMapping> AssetZoneMappings { get; set; }

    public virtual DbSet<AssetZoneStruct> AssetZoneStructs { get; set; }

    public virtual DbSet<AssignMemberToObject> AssignMemberToObjects { get; set; }

    public virtual DbSet<AttrGalaxy> AttrGalaxies { get; set; }

    public virtual DbSet<AttrGalaxyAet> AttrGalaxyAets { get; set; }

    public virtual DbSet<AttrManager> AttrManagers { get; set; }

    public virtual DbSet<AttrManagerGalaxy> AttrManagerGalaxies { get; set; }

    public virtual DbSet<AttrSetup> AttrSetups { get; set; }

    public virtual DbSet<BotSocialManagement> BotSocialManagements { get; set; }

    public virtual DbSet<BotSocialSessionLog> BotSocialSessionLogs { get; set; }

    public virtual DbSet<CameraRoom> CameraRooms { get; set; }

    public virtual DbSet<CandidateBasic> CandidateBasics { get; set; }

    public virtual DbSet<CandidateCvStorage> CandidateCvStorages { get; set; }

    public virtual DbSet<CandidateInterview> CandidateInterviews { get; set; }

    public virtual DbSet<CandidateWorkEvent> CandidateWorkEvents { get; set; }

    public virtual DbSet<CardAttachment> CardAttachments { get; set; }

    public virtual DbSet<CardAttachmentCopy> CardAttachmentCopies { get; set; }

    public virtual DbSet<CardCommentList> CardCommentLists { get; set; }

    public virtual DbSet<CardItemCheck> CardItemChecks { get; set; }

    public virtual DbSet<CardItemCheckTrackingProgress> CardItemCheckTrackingProgresses { get; set; }

    public virtual DbSet<CardMapping> CardMappings { get; set; }

    public virtual DbSet<CardProduct> CardProducts { get; set; }

    public virtual DbSet<CardSubitemCheck> CardSubitemChecks { get; set; }

    public virtual DbSet<CardUserActivity> CardUserActivities { get; set; }

    public virtual DbSet<CareerCatScale> CareerCatScales { get; set; }

    public virtual DbSet<CatActivity> CatActivities { get; set; }

    public virtual DbSet<CatWorkFlow> CatWorkFlows { get; set; }

    public virtual DbSet<CategoryCareer> CategoryCareers { get; set; }

    public virtual DbSet<CategoryWorksheet> CategoryWorksheets { get; set; }

    public virtual DbSet<ChatGroup> ChatGroups { get; set; }

    public virtual DbSet<ChatHistory> ChatHistories { get; set; }

    public virtual DbSet<CmsAttachment> CmsAttachments { get; set; }

    public virtual DbSet<CmsCategory> CmsCategories { get; set; }

    public virtual DbSet<CmsComment> CmsComments { get; set; }

    public virtual DbSet<CmsExtraField> CmsExtraFields { get; set; }

    public virtual DbSet<CmsExtraFieldsGroup> CmsExtraFieldsGroups { get; set; }

    public virtual DbSet<CmsExtraFieldsValue> CmsExtraFieldsValues { get; set; }

    public virtual DbSet<CmsFunction> CmsFunctions { get; set; }

    public virtual DbSet<CmsFunctionGroup> CmsFunctionGroups { get; set; }

    public virtual DbSet<CmsFunctionResource> CmsFunctionResources { get; set; }

    public virtual DbSet<CmsItem> CmsItems { get; set; }

    public virtual DbSet<CmsRating> CmsRatings { get; set; }

    public virtual DbSet<CmsRole> CmsRoles { get; set; }

    public virtual DbSet<CmsSetting> CmsSettings { get; set; }

    public virtual DbSet<CmsTag> CmsTags { get; set; }

    public virtual DbSet<CmsTagsXref> CmsTagsXrefs { get; set; }

    public virtual DbSet<CoinRateExchange> CoinRateExchanges { get; set; }

    public virtual DbSet<CommAttribute> CommAttributes { get; set; }

    public virtual DbSet<CommitmentDetail> CommitmentDetails { get; set; }

    public virtual DbSet<CommitmentHeader> CommitmentHeaders { get; set; }

    public virtual DbSet<CommonSetting> CommonSettings { get; set; }

    public virtual DbSet<CommonSettingArticle> CommonSettingArticles { get; set; }

    public virtual DbSet<CommonSettingCategory> CommonSettingCategories { get; set; }

    public virtual DbSet<CommonSettingCategoryCopy> CommonSettingCategoryCopies { get; set; }

    public virtual DbSet<CommonSettingGroup> CommonSettingGroups { get; set; }

    public virtual DbSet<CompanyRuleItem> CompanyRuleItems { get; set; }

    public virtual DbSet<CompanyScheduleWork> CompanyScheduleWorks { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ContractActivity> ContractActivities { get; set; }

    public virtual DbSet<ContractAttribute> ContractAttributes { get; set; }

    public virtual DbSet<ContractAttributeHi> ContractAttributeHis { get; set; }

    public virtual DbSet<ContractDetail> ContractDetails { get; set; }

    public virtual DbSet<ContractFile> ContractFiles { get; set; }

    public virtual DbSet<ContractMemberTask> ContractMemberTasks { get; set; }

    public virtual DbSet<ContractNote> ContractNotes { get; set; }

    public virtual DbSet<ContractPeopleTag> ContractPeopleTags { get; set; }

    public virtual DbSet<ContractSchedulePay> ContractSchedulePays { get; set; }

    public virtual DbSet<ContractSchedulePayHi> ContractSchedulePayHis { get; set; }

    public virtual DbSet<ContractServiceDetail> ContractServiceDetails { get; set; }

    public virtual DbSet<ContractServiceDetailHi> ContractServiceDetailHis { get; set; }

    public virtual DbSet<CostTableLog> CostTableLogs { get; set; }

    public virtual DbSet<CrawlerBotManagement> CrawlerBotManagements { get; set; }

    public virtual DbSet<CrawlerDomainConfiguration> CrawlerDomainConfigurations { get; set; }

    public virtual DbSet<CrawlerDomainConfigurationParam> CrawlerDomainConfigurationParams { get; set; }

    public virtual DbSet<CrawlerJobSchedule> CrawlerJobSchedules { get; set; }

    public virtual DbSet<CrawlerKeyword> CrawlerKeywords { get; set; }

    public virtual DbSet<CrawlerManageIpRunningBot> CrawlerManageIpRunningBots { get; set; }

    public virtual DbSet<CrawlerRunningLog> CrawlerRunningLogs { get; set; }

    public virtual DbSet<CrawlerSessionContentResult> CrawlerSessionContentResults { get; set; }

    public virtual DbSet<CrawlerSocialNetworkParam> CrawlerSocialNetworkParams { get; set; }

    public virtual DbSet<CriteriaRecruitmentAttrDatum> CriteriaRecruitmentAttrData { get; set; }

    public virtual DbSet<CriteriaRecruitmentCat> CriteriaRecruitmentCats { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAppointment> CustomerAppointments { get; set; }

    public virtual DbSet<CustomerAttribute> CustomerAttributes { get; set; }

    public virtual DbSet<CustomerExtend> CustomerExtends { get; set; }

    public virtual DbSet<CustomerFile> CustomerFiles { get; set; }

    public virtual DbSet<CustomerReminder> CustomerReminders { get; set; }

    public virtual DbSet<DashboardDataJson> DashboardDataJsons { get; set; }

    public virtual DbSet<DashboardDataJsonCopy> DashboardDataJsonCopies { get; set; }

    public virtual DbSet<DbVAmchartSocialSessionLog> DbVAmchartSocialSessionLogs { get; set; }

    public virtual DbSet<DecisionBonusDisciplineDetail> DecisionBonusDisciplineDetails { get; set; }

    public virtual DbSet<DecisionBonusDisciplineHeader> DecisionBonusDisciplineHeaders { get; set; }

    public virtual DbSet<DecisionMovementDetail> DecisionMovementDetails { get; set; }

    public virtual DbSet<DecisionMovementHeader> DecisionMovementHeaders { get; set; }

    public virtual DbSet<DeviceMeetingControl> DeviceMeetingControls { get; set; }

    public virtual DbSet<DispatchesCategory> DispatchesCategories { get; set; }

    public virtual DbSet<DispatchesCommentAct> DispatchesCommentActs { get; set; }

    public virtual DbSet<DispatchesFilesAct> DispatchesFilesActs { get; set; }

    public virtual DbSet<DispatchesHeader> DispatchesHeaders { get; set; }

    public virtual DbSet<DispatchesMemberActivity> DispatchesMemberActivities { get; set; }

    public virtual DbSet<DispatchesTrackingProcess> DispatchesTrackingProcesses { get; set; }

    public virtual DbSet<DispatchesUser> DispatchesUsers { get; set; }

    public virtual DbSet<DispatchesWeekWorkingScheduler> DispatchesWeekWorkingSchedulers { get; set; }

    public virtual DbSet<DynamicRegistSurvey> DynamicRegistSurveys { get; set; }

    public virtual DbSet<DynamicRegistSurveyDatum> DynamicRegistSurveyData { get; set; }

    public virtual DbSet<DynamicSurveyUser> DynamicSurveyUsers { get; set; }

    public virtual DbSet<EdmsAudioBook> EdmsAudioBooks { get; set; }

    public virtual DbSet<EdmsBox> EdmsBoxes { get; set; }

    public virtual DbSet<EdmsBoxFile> EdmsBoxFiles { get; set; }

    public virtual DbSet<EdmsBoxTracking> EdmsBoxTrackings { get; set; }

    public virtual DbSet<EdmsCatRepoSetting> EdmsCatRepoSettings { get; set; }

    public virtual DbSet<EdmsCategory> EdmsCategories { get; set; }

    public virtual DbSet<EdmsEntityMapping> EdmsEntityMappings { get; set; }

    public virtual DbSet<EdmsEntityMappingAsset> EdmsEntityMappingAssets { get; set; }

    public virtual DbSet<EdmsEntityMappingDocument> EdmsEntityMappingDocuments { get; set; }

    public virtual DbSet<EdmsFile> EdmsFiles { get; set; }

    public virtual DbSet<EdmsFilePackCover> EdmsFilePackCovers { get; set; }

    public virtual DbSet<EdmsFilePackCoverAsset> EdmsFilePackCoverAssets { get; set; }

    public virtual DbSet<EdmsFilePermission> EdmsFilePermissions { get; set; }

    public virtual DbSet<EdmsFloor> EdmsFloors { get; set; }

    public virtual DbSet<EdmsFloorAsset> EdmsFloorAssets { get; set; }

    public virtual DbSet<EdmsFloorDocument> EdmsFloorDocuments { get; set; }

    public virtual DbSet<EdmsLine> EdmsLines { get; set; }

    public virtual DbSet<EdmsLineAsset> EdmsLineAssets { get; set; }

    public virtual DbSet<EdmsLineDocument> EdmsLineDocuments { get; set; }

    public virtual DbSet<EdmsMoveBoxLog> EdmsMoveBoxLogs { get; set; }

    public virtual DbSet<EdmsMoveBoxLogDocument> EdmsMoveBoxLogDocuments { get; set; }

    public virtual DbSet<EdmsMoveProductLog> EdmsMoveProductLogs { get; set; }

    public virtual DbSet<EdmsObjectShareFile> EdmsObjectShareFiles { get; set; }

    public virtual DbSet<EdmsRack> EdmsRacks { get; set; }

    public virtual DbSet<EdmsRackAsset> EdmsRackAssets { get; set; }

    public virtual DbSet<EdmsRackDocument> EdmsRackDocuments { get; set; }

    public virtual DbSet<EdmsReceiptExportFile> EdmsReceiptExportFiles { get; set; }

    public virtual DbSet<EdmsReceiptExportStore> EdmsReceiptExportStores { get; set; }

    public virtual DbSet<EdmsReceiptInputFile> EdmsReceiptInputFiles { get; set; }

    public virtual DbSet<EdmsReceiptInputStore> EdmsReceiptInputStores { get; set; }

    public virtual DbSet<EdmsRemove> EdmsRemoves { get; set; }

    public virtual DbSet<EdmsRemoveBox> EdmsRemoveBoxes { get; set; }

    public virtual DbSet<EdmsRepoCatFile> EdmsRepoCatFiles { get; set; }

    public virtual DbSet<EdmsRepoDefaultObject> EdmsRepoDefaultObjects { get; set; }

    public virtual DbSet<EdmsRepository> EdmsRepositories { get; set; }

    public virtual DbSet<EdmsRequestEndBox> EdmsRequestEndBoxes { get; set; }

    public virtual DbSet<EdmsRequestExportFile> EdmsRequestExportFiles { get; set; }

    public virtual DbSet<EdmsRequestExportStore> EdmsRequestExportStores { get; set; }

    public virtual DbSet<EdmsRequestFile> EdmsRequestFiles { get; set; }

    public virtual DbSet<EdmsRequestInputFile> EdmsRequestInputFiles { get; set; }

    public virtual DbSet<EdmsRequestInputStore> EdmsRequestInputStores { get; set; }

    public virtual DbSet<EdmsRequestTracking> EdmsRequestTrackings { get; set; }

    public virtual DbSet<EdmsTermite> EdmsTermites { get; set; }

    public virtual DbSet<EdmsTermiteBox> EdmsTermiteBoxes { get; set; }

    public virtual DbSet<EdmsTimeOfDocumentPreservation> EdmsTimeOfDocumentPreservations { get; set; }

    public virtual DbSet<EdmsTimeOfDocumentPreservationCommon> EdmsTimeOfDocumentPreservationCommons { get; set; }

    public virtual DbSet<EdmsWarehouse> EdmsWarehouses { get; set; }

    public virtual DbSet<EdmsWarehouseAsset> EdmsWarehouseAssets { get; set; }

    public virtual DbSet<EdmsWarehouseDocument> EdmsWarehouseDocuments { get; set; }

    public virtual DbSet<EdmsWarehouseExtend> EdmsWarehouseExtends { get; set; }

    public virtual DbSet<EdmsWarehouseMedium> EdmsWarehouseMedia { get; set; }

    public virtual DbSet<EdmsWarehouseUser> EdmsWarehouseUsers { get; set; }

    public virtual DbSet<EdmsWhsMedium> EdmsWhsMedia { get; set; }

    public virtual DbSet<EdmsWhsQrcode> EdmsWhsQrcodes { get; set; }

    public virtual DbSet<EdmsWhsQrcodeAsset> EdmsWhsQrcodeAssets { get; set; }

    public virtual DbSet<EdmsWhsQrcodeDocument> EdmsWhsQrcodeDocuments { get; set; }

    public virtual DbSet<EduCategory> EduCategories { get; set; }

    public virtual DbSet<EduExamination> EduExaminations { get; set; }

    public virtual DbSet<EduExaminationDetail> EduExaminationDetails { get; set; }

    public virtual DbSet<EduExtraFieldGroup> EduExtraFieldGroups { get; set; }

    public virtual DbSet<EduLecture> EduLectures { get; set; }

    public virtual DbSet<EmployeeCertificate> EmployeeCertificates { get; set; }

    public virtual DbSet<EmployeeCoaching> EmployeeCoachings { get; set; }

    public virtual DbSet<EmployeeStatusTracking> EmployeeStatusTrackings { get; set; }

    public virtual DbSet<EntityMapping> EntityMappings { get; set; }

    public virtual DbSet<ExcuterControlRole> ExcuterControlRoles { get; set; }

    public virtual DbSet<ExcuterControlRoleInst> ExcuterControlRoleInsts { get; set; }

    public virtual DbSet<FaceFaceId> FaceFaceIds { get; set; }

    public virtual DbSet<FacoProductCat> FacoProductCats { get; set; }

    public virtual DbSet<FcmToken> FcmTokens { get; set; }

    public virtual DbSet<FileObjectShare> FileObjectShares { get; set; }

    public virtual DbSet<FileRecruitment> FileRecruitments { get; set; }

    public virtual DbSet<FileVersion> FileVersions { get; set; }

    public virtual DbSet<FilesShareObjectUser> FilesShareObjectUsers { get; set; }

    public virtual DbSet<ForecastProductInStock> ForecastProductInStocks { get; set; }

    public virtual DbSet<FormCat> FormCats { get; set; }

    public virtual DbSet<FormControl> FormControls { get; set; }

    public virtual DbSet<FundAccEntry> FundAccEntries { get; set; }

    public virtual DbSet<FundAccEntryTracking> FundAccEntryTrackings { get; set; }

    public virtual DbSet<FundCatReptExp> FundCatReptExps { get; set; }

    public virtual DbSet<FundCurrency> FundCurrencies { get; set; }

    public virtual DbSet<FundExchangeRate> FundExchangeRates { get; set; }

    public virtual DbSet<FundExchangeRateCopy> FundExchangeRateCopies { get; set; }

    public virtual DbSet<FundFile> FundFiles { get; set; }

    public virtual DbSet<FundLoadingSmsBank> FundLoadingSmsBanks { get; set; }

    public virtual DbSet<FundRelativeObjMng> FundRelativeObjMngs { get; set; }

    public virtual DbSet<GalaxyKeyword> GalaxyKeywords { get; set; }

    public virtual DbSet<GetCountCardWork> GetCountCardWorks { get; set; }

    public virtual DbSet<HolidayDate> HolidayDates { get; set; }

    public virtual DbSet<HrAddress> HrAddresses { get; set; }

    public virtual DbSet<HrContact> HrContacts { get; set; }

    public virtual DbSet<HrContract> HrContracts { get; set; }

    public virtual DbSet<HrEmployee> HrEmployees { get; set; }

    /*public virtual DbSet<HrEmployeeDecision> HrEmployeeDecisions { get; set; }

    public virtual DbSet<HrEmployeeMobilization> HrEmployeeMobilizations { get; set; }*/

    public virtual DbSet<HrRomoocDriver> HrRomoocDrivers { get; set; }

    /*public virtual DbSet<HrTrainingCourse> HrTrainingCourses { get; set; }

    public virtual DbSet<HrTranningCourseFile> HrTranningCourseFiles { get; set; }*/

    public virtual DbSet<HrWorkflow> HrWorkflows { get; set; }

    /*public virtual DbSet<HrWorkingProcess> HrWorkingProcesses { get; set; }*/

    public virtual DbSet<IotAnalysisAction> IotAnalysisActions { get; set; }

    /*public virtual DbSet<IotCarInOut> IotCarInOuts { get; set; }

    public virtual DbSet<IotDeviceInfo> IotDeviceInfos { get; set; }*/

    /*public virtual DbSet<IotSensor> IotSensors { get; set; }

    public virtual DbSet<IotSetUpAlert> IotSetUpAlerts { get; set; }

    public virtual DbSet<IotWarningSetting> IotWarningSettings { get; set; }

    public virtual DbSet<ItemPackUser> ItemPackUsers { get; set; }*/

    public virtual DbSet<ItemPlanJobcard> ItemPlanJobcards { get; set; }

    /*public virtual DbSet<JcObjectIdRelative> JcObjectIdRelatives { get; set; }*/

    public virtual DbSet<JcObjectIdRelative100k> JcObjectIdRelative100ks { get; set; }

    public virtual DbSet<JcObjectIdRelativeSource> JcObjectIdRelativeSources { get; set; }

    /*public virtual DbSet<JcObjectType> JcObjectTypes { get; set; }

    public virtual DbSet<JcProduct> JcProducts { get; set; }

    public virtual DbSet<JcService> JcServices { get; set; }

    public virtual DbSet<JcTrackingBuilding> JcTrackingBuildings { get; set; }*/

    public virtual DbSet<JcTrackingMedium> JcTrackingMedia { get; set; }

    /*public virtual DbSet<JckMaterialsComsume> JckMaterialsComsumes { get; set; }

    public virtual DbSet<JobCardAssignee> JobCardAssignees { get; set; }

    public virtual DbSet<JobcardDataLogger> JobcardDataLoggers { get; set; }

    public virtual DbSet<JobcardLink> JobcardLinks { get; set; }

    public virtual DbSet<KeyWordDataPool> KeyWordDataPools { get; set; }

    public virtual DbSet<LectureDiscuss> LectureDiscusses { get; set; }*/

    public virtual DbSet<LinkedInDataProfileId> LinkedInDataProfileIds { get; set; }

    public virtual DbSet<LinkedInDataProfileUser> LinkedInDataProfileUsers { get; set; }

    public virtual DbSet<LinkedInInfoDatum> LinkedInInfoData { get; set; }

    /*public virtual DbSet<LmsBoardTask> LmsBoardTasks { get; set; }*/

    public virtual DbSet<LmsClass> LmsClasses { get; set; }

    public virtual DbSet<LmsCommonSettingCat> LmsCommonSettingCats { get; set; }

    public virtual DbSet<LmsCommonSettingValue> LmsCommonSettingValues { get; set; }

    public virtual DbSet<LmsCourse> LmsCourses { get; set; }

    public virtual DbSet<LmsExamDetail> LmsExamDetails { get; set; }

    public virtual DbSet<LmsExamHeader> LmsExamHeaders { get; set; }

    public virtual DbSet<LmsExamScheduler> LmsExamSchedulers { get; set; }

    public virtual DbSet<LmsLectureManagement> LmsLectureManagements { get; set; }

    public virtual DbSet<LmsLectureSubjectCourse> LmsLectureSubjectCourses { get; set; }

    public virtual DbSet<LmsListTask> LmsListTasks { get; set; }

    public virtual DbSet<LmsMentorMentee> LmsMentorMentees { get; set; }

    public virtual DbSet<LmsMsgNotification> LmsMsgNotifications { get; set; }

    public virtual DbSet<LmsPracticeTestDetail> LmsPracticeTestDetails { get; set; }

    public virtual DbSet<LmsPracticeTestDetail1> LmsPracticeTestDetail1s { get; set; }

    public virtual DbSet<LmsPracticeTestHeader> LmsPracticeTestHeaders { get; set; }

    public virtual DbSet<LmsPracticeTestHeader1> LmsPracticeTestHeader1s { get; set; }

    public virtual DbSet<LmsQuizLectureSubjectCourse> LmsQuizLectureSubjectCourses { get; set; }

    public virtual DbSet<LmsQuizPoolReference> LmsQuizPoolReferences { get; set; }

    public virtual DbSet<LmsSubject> LmsSubjects { get; set; }

    public virtual DbSet<LmsSubjectManagement> LmsSubjectManagements { get; set; }

    public virtual DbSet<LmsTask> LmsTasks { get; set; }

    public virtual DbSet<LmsTaskActivity> LmsTaskActivities { get; set; }

    public virtual DbSet<LmsTaskCommentList> LmsTaskCommentLists { get; set; }

    public virtual DbSet<LmsTaskStudentAssign> LmsTaskStudentAssigns { get; set; }

    public virtual DbSet<LmsTaskUserItemProgress> LmsTaskUserItemProgresses { get; set; }

    public virtual DbSet<LmsTrackDiligence> LmsTrackDiligences { get; set; }

    public virtual DbSet<LmsTutoringSchedule> LmsTutoringSchedules { get; set; }

    public virtual DbSet<LmsUserClass> LmsUserClasses { get; set; }

    public virtual DbSet<LmsUserMsg> LmsUserMsgs { get; set; }

    public virtual DbSet<LmsWithdrawn> LmsWithdrawns { get; set; }

    public virtual DbSet<LogChangeDocument> LogChangeDocuments { get; set; }

    public virtual DbSet<LogMessage> LogMessages { get; set; }

    public virtual DbSet<LotProduct> LotProducts { get; set; }

    public virtual DbSet<LotProductDetail> LotProductDetails { get; set; }

    public virtual DbSet<MapDataGp> MapDataGps { get; set; }

    public virtual DbSet<MapStockProdIn> MapStockProdIns { get; set; }

    public virtual DbSet<MappingControllerTable> MappingControllerTables { get; set; }

    public virtual DbSet<MappingMain> MappingMains { get; set; }

    public virtual DbSet<MappingModul> MappingModuls { get; set; }

    public virtual DbSet<MaterialAttribute> MaterialAttributes { get; set; }

    public virtual DbSet<MaterialFile> MaterialFiles { get; set; }

    public virtual DbSet<MaterialInvoice> MaterialInvoices { get; set; }

    public virtual DbSet<MaterialPaymentTicket> MaterialPaymentTickets { get; set; }

    public virtual DbSet<MaterialProduct> MaterialProducts { get; set; }

    public virtual DbSet<MaterialProductGroup> MaterialProductGroups { get; set; }

    public virtual DbSet<MaterialStore> MaterialStores { get; set; }

    public virtual DbSet<MaterialStoreBatchGood> MaterialStoreBatchGoods { get; set; }

    public virtual DbSet<MaterialType> MaterialTypes { get; set; }

    public virtual DbSet<MeetingSchedule> MeetingSchedules { get; set; }

    public virtual DbSet<MessageActivity> MessageActivities { get; set; }

    public virtual DbSet<MobiFunctionJobcardList> MobiFunctionJobcardLists { get; set; }

    public virtual DbSet<MobileAppFunction> MobileAppFunctions { get; set; }

    public virtual DbSet<MobileFunction> MobileFunctions { get; set; }

    public virtual DbSet<MobilePermission> MobilePermissions { get; set; }

    public virtual DbSet<MobileResource> MobileResources { get; set; }

    public virtual DbSet<MoiblePrivilege> MoiblePrivileges { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationManager> NotificationManagers { get; set; }

    public virtual DbSet<NotificationObject> NotificationObjects { get; set; }

    public virtual DbSet<NotificationSetting> NotificationSettings { get; set; }

    public virtual DbSet<NumberPhoneDn> NumberPhoneDns { get; set; }

    public virtual DbSet<ObeAccount> ObeAccounts { get; set; }

    public virtual DbSet<ObeAiRecognitionTracking> ObeAiRecognitionTrackings { get; set; }

    public virtual DbSet<ObeListDevice> ObeListDevices { get; set; }

    public virtual DbSet<ObjectTypeStatusGroup> ObjectTypeStatusGroups { get; set; }

    public virtual DbSet<ObjectiverPackCover> ObjectiverPackCovers { get; set; }

    public virtual DbSet<ObjectiverPackCoverAsset> ObjectiverPackCoverAssets { get; set; }

    public virtual DbSet<OperationLog> OperationLogs { get; set; }

    public virtual DbSet<OperationOnlineSupport> OperationOnlineSupports { get; set; }

    public virtual DbSet<OperationOnlineSupportTracking> OperationOnlineSupportTrackings { get; set; }

    public virtual DbSet<OrderRequestRaw> OrderRequestRaws { get; set; }

    public virtual DbSet<OrderRequestRaw275> OrderRequestRaw275s { get; set; }

    public virtual DbSet<OrderRequestRaw288> OrderRequestRaw288s { get; set; }

    public virtual DbSet<OrderRequestRawFile> OrderRequestRawFiles { get; set; }

    public virtual DbSet<OrderRequestRawFiles275> OrderRequestRawFiles275s { get; set; }

    public virtual DbSet<OtpManger> OtpMangers { get; set; }

    public virtual DbSet<PAreaCategory> PAreaCategories { get; set; }

    public virtual DbSet<PAreaCategoryStore> PAreaCategoryStores { get; set; }

    public virtual DbSet<PAreaMapping> PAreaMappings { get; set; }

    public virtual DbSet<PAreaMappingStore> PAreaMappingStores { get; set; }

    public virtual DbSet<PackingType> PackingTypes { get; set; }

    public virtual DbSet<Param4Warning> Param4Warnings { get; set; }

    public virtual DbSet<PayDecisionDetail> PayDecisionDetails { get; set; }

    public virtual DbSet<PayDecisionHeader> PayDecisionHeaders { get; set; }

    public virtual DbSet<PayScale> PayScales { get; set; }

    public virtual DbSet<PayScaleDetail> PayScaleDetails { get; set; }

    public virtual DbSet<PaySheet> PaySheets { get; set; }

    public virtual DbSet<PaymentGateway> PaymentGateways { get; set; }

    public virtual DbSet<PinDatum> PinData { get; set; }

    public virtual DbSet<PlanExcuteRecruitmentDetail> PlanExcuteRecruitmentDetails { get; set; }

    public virtual DbSet<PlanExcuteRecruitmentHeader> PlanExcuteRecruitmentHeaders { get; set; }

    public virtual DbSet<PlanRecruitmentDetail> PlanRecruitmentDetails { get; set; }

    public virtual DbSet<PlanRecruitmentHeader> PlanRecruitmentHeaders { get; set; }

    public virtual DbSet<PluginManage> PluginManages { get; set; }

    public virtual DbSet<PoBuyerDetail> PoBuyerDetails { get; set; }

    public virtual DbSet<PoBuyerHeader> PoBuyerHeaders { get; set; }

    public virtual DbSet<PoBuyerHeaderNotDone> PoBuyerHeaderNotDones { get; set; }

    public virtual DbSet<PoBuyerHeaderPayment> PoBuyerHeaderPayments { get; set; }

    public virtual DbSet<PoCusUpdatedTracking> PoCusUpdatedTrackings { get; set; }

    public virtual DbSet<PoSaleHeader> PoSaleHeaders { get; set; }

    public virtual DbSet<PoSaleHeaderHi> PoSaleHeaderHis { get; set; }

    public virtual DbSet<PoSaleHeaderNotDone> PoSaleHeaderNotDones { get; set; }

   /* public virtual DbSet<PoSaleProductDetail> PoSaleProductDetails { get; set; }

    public virtual DbSet<PoSupAttribute> PoSupAttributes { get; set; }*/

    public virtual DbSet<PoSupFile> PoSupFiles { get; set; }

    /*public virtual DbSet<PoSupRequestImpProduct> PoSupRequestImpProducts { get; set; }*/

    public virtual DbSet<PoSupUpdatedTracking> PoSupUpdatedTrackings { get; set; }

    public virtual DbSet<PoolMemberNotification> PoolMemberNotifications { get; set; }

    /*public virtual DbSet<ProdDeliveryAttrValue> ProdDeliveryAttrValues { get; set; }

    public virtual DbSet<ProdDeliveryDetail> ProdDeliveryDetails { get; set; }

    public virtual DbSet<ProdDeliveryHeader> ProdDeliveryHeaders { get; set; }

    public virtual DbSet<ProdInStockAttrValue> ProdInStockAttrValues { get; set; }

    public virtual DbSet<ProdPackageDelivery> ProdPackageDeliveries { get; set; }

    public virtual DbSet<ProdPackageReceived> ProdPackageReceiveds { get; set; }

    public virtual DbSet<ProdReceivedAttrValue> ProdReceivedAttrValues { get; set; }*/

    /*public virtual DbSet<ProdReceivedDetail> ProdReceivedDetails { get; set; }

    public virtual DbSet<ProdReceivedHeader> ProdReceivedHeaders { get; set; }

    public virtual DbSet<ProductAttrExt> ProductAttrExts { get; set; }

    public virtual DbSet<ProductAttrGalaxy> ProductAttrGalaxies { get; set; }

    public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }

    public virtual DbSet<ProductComponent> ProductComponents { get; set; }

    public virtual DbSet<ProductCostDetail> ProductCostDetails { get; set; }

    public virtual DbSet<ProductCostHeader> ProductCostHeaders { get; set; }

    public virtual DbSet<ProductEntityMapping> ProductEntityMappings { get; set; }*/

   /* public virtual DbSet<ProductEntityMappingLog> ProductEntityMappingLogs { get; set; }

    public virtual DbSet<ProductInStock> ProductInStocks { get; set; }

    public virtual DbSet<ProductLotFile> ProductLotFiles { get; set; }*/

    public virtual DbSet<ProductPackMapping> ProductPackMappings { get; set; }

    /*public virtual DbSet<ProductQrCode> ProductQrCodes { get; set; }

    public virtual DbSet<ProgressTracking> ProgressTrackings { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectAppointment> ProjectAppointments { get; set; }

    public virtual DbSet<ProjectAttribute> ProjectAttributes { get; set; }

    public virtual DbSet<ProjectCusSup> ProjectCusSups { get; set; }

    public virtual DbSet<ProjectFile> ProjectFiles { get; set; }*/

    /*public virtual DbSet<ProjectItemPlan> ProjectItemPlans { get; set; }

    public virtual DbSet<ProjectMember> ProjectMembers { get; set; }

    public virtual DbSet<ProjectNote> ProjectNotes { get; set; }

    public virtual DbSet<ProjectProduct> ProjectProducts { get; set; }

    public virtual DbSet<ProjectProductDetail> ProjectProductDetails { get; set; }

    public virtual DbSet<ProjectProductHeader> ProjectProductHeaders { get; set; }

    public virtual DbSet<ProjectService> ProjectServices { get; set; }

    public virtual DbSet<ProjectServiceDetail> ProjectServiceDetails { get; set; }

    public virtual DbSet<ProjectServiceHeader> ProjectServiceHeaders { get; set; }

    public virtual DbSet<ProjectSupplier> ProjectSuppliers { get; set; }

    public virtual DbSet<ProjectTeam> ProjectTeams { get; set; }

    public virtual DbSet<ProjectTeamUser> ProjectTeamUsers { get; set; }

    public virtual DbSet<QuizPool> QuizPools { get; set; }

    public virtual DbSet<RecordDeliveryDetail> RecordDeliveryDetails { get; set; }

    public virtual DbSet<RecordDeliveryHeader> RecordDeliveryHeaders { get; set; }

    public virtual DbSet<RecordsPack> RecordsPacks { get; set; }

    public virtual DbSet<RecordsPackArrangeLog> RecordsPackArrangeLogs { get; set; }

    public virtual DbSet<RecordsPackAttr> RecordsPackAttrs { get; set; }*/

    public virtual DbSet<RecordsPackFile> RecordsPackFiles { get; set; }

    /*public virtual DbSet<RecruitmentScheduler> RecruitmentSchedulers { get; set; }

    public virtual DbSet<ReminderAttr> ReminderAttrs { get; set; }

    public virtual DbSet<RequestImpProductDetail> RequestImpProductDetails { get; set; }

    public virtual DbSet<RequestImpProductHeader> RequestImpProductHeaders { get; set; }

    public virtual DbSet<RequestPoSup> RequestPoSups { get; set; }

    public virtual DbSet<RequestPriceDetail> RequestPriceDetails { get; set; }

    public virtual DbSet<RequestPriceHeader> RequestPriceHeaders { get; set; }

    public virtual DbSet<ResultFindOcr> ResultFindOcrs { get; set; }

    public virtual DbSet<RmCancelTracking> RmCancelTrackings { get; set; }
    */
    //public virtual DbSet<RmCommandOrderTruck> RmCommandOrderTrucks { get; set; }

    public virtual DbSet<RmCommonSetting> RmCommonSettings { get; set; }

    //public virtual DbSet<RmDriverActivityLog> RmDriverActivityLogs { get; set; }

    //public virtual DbSet<RmECompany> RmECompanies { get; set; }

    //public virtual DbSet<RmGisTable> RmGisTables { get; set; }

    //public virtual DbSet<RmHrEmployee> RmHrEmployees { get; set; }

    public virtual DbSet<RmJnanaApiGoogleService> RmJnanaApiGoogleServices { get; set; }

    //public virtual DbSet<RmJnanaCountRequestGoogle> RmJnanaCountRequestGoogles { get; set; }

    //public virtual DbSet<RmJnanaFcm> RmJnanaFcms { get; set; }

    //public virtual DbSet<RmJnanaFcmMessage> RmJnanaFcmMessages { get; set; }

    //public virtual DbSet<RmJnanaFile> RmJnanaFiles { get; set; }

    //public virtual DbSet<RmJnanaNewsArticle> RmJnanaNewsArticles { get; set; }

    //public virtual DbSet<RmJnanaNewsArticleFile> RmJnanaNewsArticleFiles { get; set; }

    //public virtual DbSet<RmJnanaNewsCat> RmJnanaNewsCats { get; set; }

    public virtual DbSet<RmRomoocCurrentPosition> RmRomoocCurrentPositions { get; set; }

    //public virtual DbSet<RmRomoocDriver> RmRomoocDrivers { get; set; }

    //public virtual DbSet<RmRomoocExtrafield> RmRomoocExtrafields { get; set; }

    public virtual DbSet<RmRomoocFcm> RmRomoocFcms { get; set; }

    public virtual DbSet<RmRomoocFcmMessage> RmRomoocFcmMessages { get; set; }

    public virtual DbSet<RmRomoocPacking> RmRomoocPackings { get; set; }

    public virtual DbSet<RmRomoocRemooc> RmRomoocRemoocs { get; set; }

    public virtual DbSet<RmRomoocTracking> RmRomoocTrackings { get; set; }

    public virtual DbSet<RmRomoocTractor> RmRomoocTractors { get; set; }

    //public virtual DbSet<RmSosInfo> RmSosInfos { get; set; }

    public virtual DbSet<RmSosMedium> RmSosMedia { get; set; }

    //public virtual DbSet<RmVayxeActivityRequestStatusDelivery> RmVayxeActivityRequestStatusDeliveries { get; set; }

    //public virtual DbSet<RmVayxeBookChecking> RmVayxeBookCheckings { get; set; }

    public virtual DbSet<RmVayxeBookMaterialDetail> RmVayxeBookMaterialDetails { get; set; }

    public virtual DbSet<RmVayxeBookServiceDetail> RmVayxeBookServiceDetails { get; set; }

    public virtual DbSet<RmVayxeCatSevice> RmVayxeCatSevices { get; set; }

    public virtual DbSet<RmVayxeMaterialGood> RmVayxeMaterialGoods { get; set; }

    public virtual DbSet<RmVayxeTableCostDetail> RmVayxeTableCostDetails { get; set; }

    //public virtual DbSet<RmVayxeTableCostHeader> RmVayxeTableCostHeaders { get; set; }

    //public virtual DbSet<RmVayxeVendor> RmVayxeVendors { get; set; }

    //public virtual DbSet<SalaryEmployeeMonth> SalaryEmployeeMonths { get; set; }

    //public virtual DbSet<SalaryTableAllowance> SalaryTableAllowances { get; set; }

    public virtual DbSet<ServiceCat> ServiceCats { get; set; }

    public virtual DbSet<ServiceCatAttribute> ServiceCatAttributes { get; set; }

    public virtual DbSet<ServiceCatCostCondition> ServiceCatCostConditions { get; set; }

    public virtual DbSet<ServiceCatCostHeader> ServiceCatCostHeaders { get; set; }

    public virtual DbSet<ServiceCatGroup> ServiceCatGroups { get; set; }

    public virtual DbSet<ServiceCatType> ServiceCatTypes { get; set; }

    public virtual DbSet<SessionItemChkItem> SessionItemChkItems { get; set; }

    //public virtual DbSet<SessionWork> SessionWorks { get; set; }

    //public virtual DbSet<SessionWorkResult> SessionWorkResults { get; set; }

    //public virtual DbSet<SetCompanyMenu> SetCompanyMenus { get; set; }

    public virtual DbSet<SetIcon2Object> SetIcon2Objects { get; set; }

    //public virtual DbSet<SettingUserguide> SettingUserguides { get; set; }

    //public virtual DbSet<ShiftLog> ShiftLogs { get; set; }

    //public virtual DbSet<StaffScheduleWork> StaffScheduleWorks { get; set; }

    //public virtual DbSet<StatusGroup> StatusGroups { get; set; }

    public virtual DbSet<StatusSetDetail> StatusSetDetails { get; set; }

    public virtual DbSet<StatusSetHeader> StatusSetHeaders { get; set; }

    //public virtual DbSet<StockArrangePopEntry> StockArrangePopEntries { get; set; }

    //public virtual DbSet<StockArrangePutEntry> StockArrangePutEntries { get; set; }

    //public virtual DbSet<StopContractDetail> StopContractDetails { get; set; }

    //public virtual DbSet<StopContractHeader> StopContractHeaders { get; set; }

    //public virtual DbSet<SubProduct> SubProducts { get; set; }

    //public virtual DbSet<SubWorkflowInstance> SubWorkflowInstances { get; set; }

    //public virtual DbSet<Supplier> Suppliers { get; set; }

    //public virtual DbSet<SupplierAppointment> SupplierAppointments { get; set; }

    //public virtual DbSet<SupplierExtend> SupplierExtends { get; set; }

    //public virtual DbSet<SupplierFile> SupplierFiles { get; set; }

    public virtual DbSet<TablesToUpdate> TablesToUpdates { get; set; }

    //public virtual DbSet<Team> Teams { get; set; }

    //public virtual DbSet<TempKeyWordSearch> TempKeyWordSearches { get; set; }

    //public virtual DbSet<TemplateKeySearchFile> TemplateKeySearchFiles { get; set; }

    //public virtual DbSet<TokenManager> TokenManagers { get; set; }

    public virtual DbSet<TransDeliveryNoteDetail> TransDeliveryNoteDetails { get; set; }

    public virtual DbSet<TransDeliveryNoteHeader> TransDeliveryNoteHeaders { get; set; }

    //public virtual DbSet<Transition> Transitions { get; set; }

    //public virtual DbSet<UserAccessDataKeyword> UserAccessDataKeywords { get; set; }

    //public virtual DbSet<UserDeclareBusyOrFree> UserDeclareBusyOrFrees { get; set; }

    //public virtual DbSet<UserDoExerciseResult> UserDoExerciseResults { get; set; }

    //public virtual DbSet<UserExaminationResultDetail> UserExaminationResultDetails { get; set; }

    //public virtual DbSet<UserExaminationResultSession> UserExaminationResultSessions { get; set; }

    //public virtual DbSet<UserExerciseResultDetail> UserExerciseResultDetails { get; set; }

    //public virtual DbSet<UserExerciseResultSession> UserExerciseResultSessions { get; set; }

    //public virtual DbSet<UserLearnSubject> UserLearnSubjects { get; set; }

    public virtual DbSet<UserTrackingGp> UserTrackingGps { get; set; }

    //public virtual DbSet<UserWishListSubject> UserWishListSubjects { get; set; }

    //public virtual DbSet<UsrKeyWordSetup> UsrKeyWordSetups { get; set; }

    //public virtual DbSet<VActionCard> VActionCards { get; set; }

    //public virtual DbSet<VAllObject> VAllObjects { get; set; }

    public virtual DbSet<VAllTable> VAllTables { get; set; }

    public virtual DbSet<VAmchartAsset> VAmchartAssets { get; set; }

    public virtual DbSet<VAmchartBuy> VAmchartBuys { get; set; }

    public virtual DbSet<VAmchartCardWork> VAmchartCardWorks { get; set; }

    public virtual DbSet<VAmchartCountBuy> VAmchartCountBuys { get; set; }

    public virtual DbSet<VAmchartCountCustomer> VAmchartCountCustomers { get; set; }

    public virtual DbSet<VAmchartCountEmployee> VAmchartCountEmployees { get; set; }

    public virtual DbSet<VAmchartCountProject> VAmchartCountProjects { get; set; }

    public virtual DbSet<VAmchartCountSale> VAmchartCountSales { get; set; }

    public virtual DbSet<VAmchartCountSupplier> VAmchartCountSuppliers { get; set; }

    public virtual DbSet<VAmchartCrawlingLog> VAmchartCrawlingLogs { get; set; }

    public virtual DbSet<VAmchartCustomer> VAmchartCustomers { get; set; }

    public virtual DbSet<VAmchartDoExercise> VAmchartDoExercises { get; set; }

    public virtual DbSet<VAmchartLearnSubject> VAmchartLearnSubjects { get; set; }

    public virtual DbSet<VAmchartPieBuy> VAmchartPieBuys { get; set; }

    public virtual DbSet<VAmchartPieCustomer> VAmchartPieCustomers { get; set; }

    public virtual DbSet<VAmchartPieProject> VAmchartPieProjects { get; set; }

    public virtual DbSet<VAmchartPieSale> VAmchartPieSales { get; set; }

    public virtual DbSet<VAmchartPieSupplier> VAmchartPieSuppliers { get; set; }

    public virtual DbSet<VAmchartProject> VAmchartProjects { get; set; }

    public virtual DbSet<VAmchartSale> VAmchartSales { get; set; }

    public virtual DbSet<VAmchartSupplier> VAmchartSuppliers { get; set; }

    public virtual DbSet<VAmchartWorkflow> VAmchartWorkflows { get; set; }

    public virtual DbSet<VAssetStatus> VAssetStatuses { get; set; }

    public virtual DbSet<VCardProcess> VCardProcesses { get; set; }

    public virtual DbSet<VCommonSetting> VCommonSettings { get; set; }

    public virtual DbSet<VHighchartFund> VHighchartFunds { get; set; }

    public virtual DbSet<VHighchartProd> VHighchartProds { get; set; }

    public virtual DbSet<VHisExpProduct> VHisExpProducts { get; set; }

    public virtual DbSet<VHisImpProduct> VHisImpProducts { get; set; }

    public virtual DbSet<VHisProduct> VHisProducts { get; set; }

    public virtual DbSet<VHrContract> VHrContracts { get; set; }

    public virtual DbSet<VHrEmployee> VHrEmployees { get; set; }

    public virtual DbSet<VImpExpProduct> VImpExpProducts { get; set; }

    public virtual DbSet<VListBoard> VListBoards { get; set; }

    public virtual DbSet<VListWeight> VListWeights { get; set; }

    public virtual DbSet<VProductAllTable> VProductAllTables { get; set; }

    public virtual DbSet<VProjectProductRemain> VProjectProductRemains { get; set; }

    public virtual DbSet<VQuantityInStockByStore> VQuantityInStockByStores { get; set; }

    public virtual DbSet<VReportStaticsPoCu> VReportStaticsPoCus { get; set; }

    public virtual DbSet<VReportStaticsPoSup> VReportStaticsPoSups { get; set; }

    public virtual DbSet<VSubjectHierachy> VSubjectHierachies { get; set; }

    public virtual DbSet<VTutorSession> VTutorSessions { get; set; }

    public virtual DbSet<VcAppAccessLog> VcAppAccessLogs { get; set; }

    public virtual DbSet<VcCustomerCare> VcCustomerCares { get; set; }

    public virtual DbSet<VcCustomerCareLastMonth> VcCustomerCareLastMonths { get; set; }

    public virtual DbSet<VcCustomerDeclareHeaderInfo> VcCustomerDeclareHeaderInfos { get; set; }

    public virtual DbSet<VcCustomerDeclareInfo> VcCustomerDeclareInfos { get; set; }

    public virtual DbSet<VcDriver> VcDrivers { get; set; }

    public virtual DbSet<VcFcm> VcFcms { get; set; }

    public virtual DbSet<VcFcmMessage> VcFcmMessages { get; set; }

    public virtual DbSet<VcGisTable> VcGisTables { get; set; }

    public virtual DbSet<VcJnanaFcm> VcJnanaFcms { get; set; }

    public virtual DbSet<VcJnanaFcmMessage> VcJnanaFcmMessages { get; set; }

    public virtual DbSet<VcJnanaFile> VcJnanaFiles { get; set; }

    public virtual DbSet<VcJnanaNewsArticle> VcJnanaNewsArticles { get; set; }

    public virtual DbSet<VcJnanaNewsArticleFile> VcJnanaNewsArticleFiles { get; set; }

    public virtual DbSet<VcJnanaNewsCat> VcJnanaNewsCats { get; set; }

    public virtual DbSet<VcLeaderApprove> VcLeaderApproves { get; set; }

    public virtual DbSet<VcProductCat> VcProductCats { get; set; }

    public virtual DbSet<VcSettingRoute> VcSettingRoutes { get; set; }

    public virtual DbSet<VcSosInfo> VcSosInfos { get; set; }

    public virtual DbSet<VcSosMedium> VcSosMedia { get; set; }

    public virtual DbSet<VcStoreIdea> VcStoreIdeas { get; set; }

    public virtual DbSet<VcSupplierTradeRelation> VcSupplierTradeRelations { get; set; }

    public virtual DbSet<VcTransporter> VcTransporters { get; set; }

    public virtual DbSet<VcWorkCheck> VcWorkChecks { get; set; }

    public virtual DbSet<VcWorkPlan> VcWorkPlans { get; set; }

    public virtual DbSet<VcWorkPlanLog> VcWorkPlanLogs { get; set; }

    public virtual DbSet<VocaCertificateCat> VocaCertificateCats { get; set; }

    public virtual DbSet<WalletCoinExchange> WalletCoinExchanges { get; set; }

    //public virtual DbSet<WalletCoinTransaction> WalletCoinTransactions { get; set; }

    //public virtual DbSet<WalletDepositTransaction> WalletDepositTransactions { get; set; }

    //public virtual DbSet<WalletPackage> WalletPackages { get; set; }

    //public virtual DbSet<WalletTableCostItem> WalletTableCostItems { get; set; }

    //public virtual DbSet<WarehouseRecordsPack> WarehouseRecordsPacks { get; set; }

    //public virtual DbSet<WarehouseRecordsPackAttr> WarehouseRecordsPackAttrs { get; set; }

    //public virtual DbSet<WarehouseRecordsPackFile> WarehouseRecordsPackFiles { get; set; }

    //public virtual DbSet<WarehouseZoneAttr> WarehouseZoneAttrs { get; set; }

    //public virtual DbSet<WarehouseZoneMapping> WarehouseZoneMappings { get; set; }

    //public virtual DbSet<WarehouseZoneStruct> WarehouseZoneStructs { get; set; }

    //public virtual DbSet<WeekWorkingScheduler> WeekWorkingSchedulers { get; set; }

    public virtual DbSet<WfActivityObjectProcessing> WfActivityObjectProcessings { get; set; }

    //public virtual DbSet<WfObject> WfObjects { get; set; }

    //public virtual DbSet<WfSharpLibrary> WfSharpLibraries { get; set; }

    public virtual DbSet<WhsZoneAttr> WhsZoneAttrs { get; set; }

    public virtual DbSet<WhsZoneStruct> WhsZoneStructs { get; set; }

    //public virtual DbSet<WorkEventCat> WorkEventCats { get; set; }

    public virtual DbSet<WorkExecutiveObjectrelative> WorkExecutiveObjectrelatives { get; set; }

    //public virtual DbSet<WorkFlow> WorkFlows { get; set; }

    //public virtual DbSet<WorkFlowRule> WorkFlowRules { get; set; }

    //public virtual DbSet<WorkItemAssignStaff> WorkItemAssignStaffs { get; set; }

    //public virtual DbSet<WorkItemSession> WorkItemSessions { get; set; }

    public virtual DbSet<WorkItemSessionResult> WorkItemSessionResults { get; set; }

    //public virtual DbSet<WorkOsAddressCard> WorkOsAddressCards { get; set; }

    //public virtual DbSet<WorkOsBoard> WorkOsBoards { get; set; }

    public virtual DbSet<WorkOsBoardTrackingProgress> WorkOsBoardTrackingProgresses { get; set; }

    //public virtual DbSet<WorkOsCard> WorkOsCards { get; set; }

    public virtual DbSet<WorkOsCardTrackingProgress> WorkOsCardTrackingProgresses { get; set; }

    //public virtual DbSet<WorkOsList> WorkOsLists { get; set; }

    public virtual DbSet<WorkOsListTrackingProgress> WorkOsListTrackingProgresses { get; set; }

    //public virtual DbSet<WorkShiftCheckinOut> WorkShiftCheckinOuts { get; set; }

    //public virtual DbSet<WorkUserEvent> WorkUserEvents { get; set; }

    //public virtual DbSet<WorkflowActivity> WorkflowActivities { get; set; }

    //public virtual DbSet<WorkflowActivityRole> WorkflowActivityRoles { get; set; }

    //public virtual DbSet<WorkflowInstance> WorkflowInstances { get; set; }

    //public virtual DbSet<WorkflowInstanceRunning> WorkflowInstanceRunnings { get; set; }

    //public virtual DbSet<WorkflowMilestone> WorkflowMilestones { get; set; }

    //public virtual DbSet<WorkflowSetting> WorkflowSettings { get; set; }

    //public virtual DbSet<WorkingSchedule> WorkingSchedules { get; set; }

    //public virtual DbSet<ZoneDevicePlacement> ZoneDevicePlacements { get; set; }

    //public virtual DbSet<ZoneSetup> ZoneSetups { get; set; }

    //public virtual DbSet<ZoomManage> ZoomManages { get; set; }

    //public virtual DbSet<ZoomReportError> ZoomReportErrors { get; set; }

    public virtual DbSet<_1ProductEntityMappingLog> _1ProductEntityMappingLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.1.11,1433;Database=SmartWork_MetaLearn;Uid=admin;Password=12345678;MultipleActiveResultSets=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<ActInstanceUserActivity>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ACT_INST__3214EC27EE2E2A61");
        //});

        //modelBuilder.Entity<Activity>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ACTIVITY__3214EC275DDA5254");
        //});

        modelBuilder.Entity<ActivityAttrDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ACTIVITY__3214EC27A5FD6059");
        });

        //modelBuilder.Entity<ActivityAttrSetup>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ACTIVITY__3214EC2721CDDF99");
        //});

        //modelBuilder.Entity<ActivityFile>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ACTIVITY__3214EC277BDC5287");
        //});

        modelBuilder.Entity<ActivityInstFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ACTIVITY__3214EC27A7B2A533");
        });

        //modelBuilder.Entity<ActivityInstance>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ACTIVITY__3214EC27B59793B7");
        //});

        modelBuilder.Entity<ActivityInstanceLogDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ACTIVITY__3214EC27370E26DF");
        });

        //modelBuilder.Entity<ActivityInstanceObjective>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ACTIVITY__3214EC275E41B798");
        //});

        modelBuilder.Entity<ActivityLogDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ACTIVITY__3214EC271B1D280A");
        });

        modelBuilder.Entity<ActivityTransition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ACTIVITY__3214EC27CEBBDBD1");
        });

        modelBuilder.Entity<ActivityWorkflow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ACTIVITY__3214EC27EC13127A");
        });

        modelBuilder.Entity<AdAccessLog>(entity =>
        {
            entity.HasKey(e => e.AccessLogId).HasName("PK__AD_ACCES__78B767BE88577FAB");
        });

        modelBuilder.Entity<AdActionLog>(entity =>
        {
            entity.HasKey(e => e.ActionLogId).HasName("PK__AD_ACTIO__F3959627D54E155E");

            entity.Property(e => e.ActionLogId).ValueGeneratedNever();
        });

        modelBuilder.Entity<AdAppFunction>(entity =>
        {
            entity.HasKey(e => e.AppFunctionId).HasName("PK__AD_APP_F__A5B8F153C0A1FD36");
        });

        modelBuilder.Entity<AdApplication>(entity =>
        {
            entity.Property(e => e.ApplicationId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdAuthoring>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AD_AUTHO__3214EC27CBED371E");
        });

        modelBuilder.Entity<AdDepartment>(entity =>
        {
            entity.HasKey(e => e.DepartmentCode).HasName("PK__AD_DEPAR__A0EB8FEE37739F6B");

            entity.Property(e => e.DepartmentId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdDivision>(entity =>
        {
            entity.HasKey(e => e.Division).HasName("PK__AD_DIVIS__4DFF45DE72C389E8");
        });

        modelBuilder.Entity<AdDivisionCopy>(entity =>
        {
            entity.HasKey(e => e.Division).HasName("PK__AD_DIVIS__4DFF45DE5A639B76");
        });

        modelBuilder.Entity<AdFunction>(entity =>
        {
            entity.HasKey(e => e.FunctionCode).HasName("PK__AD_FUNCT__157D5A59F9A63671");

            entity.Property(e => e.FunctionId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation).HasConstraintName("FK__AD_FUNCTI__PAREN__135DC465");
        });

        modelBuilder.Entity<AdFunctionBackUp>(entity =>
        {
            entity.HasKey(e => e.FunctionCode).HasName("PK__AD_FUNCT__157D5A5983ABCB15");

            entity.Property(e => e.FunctionId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation).HasConstraintName("FK__AD_FUNCTI__PAREN__30E33A54");
        });

        modelBuilder.Entity<AdGroupUser>(entity =>
        {
            entity.HasKey(e => e.GroupUserCode).HasName("PK__AD_GROUP__707D788F53CD764B");

            entity.Property(e => e.GroupUserId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdLanguageText>(entity =>
        {
            entity.Property(e => e.LanguageTextId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdPermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PK__AD_PERMI__EB3C611EBF206BB5");
        });

        modelBuilder.Entity<AdPrivilege>(entity =>
        {
            entity.Property(e => e.PrivilegeId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdPrivilegeBackUp>(entity =>
        {
            entity.Property(e => e.PrivilegeId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdResource>(entity =>
        {
            entity.HasKey(e => e.ResourceCode).HasName("PK__AD_RESOU__094C9AB2928C8BA2");

            entity.Property(e => e.ResourceId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdResourceBack02112020>(entity =>
        {
            entity.HasKey(e => e.ResourceCode).HasName("PK__AD_RESOU__094C9AB2343131F7");

            entity.Property(e => e.ResourceId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdResourceBackUp>(entity =>
        {
            entity.HasKey(e => e.ResourceCode).HasName("PK__AD_RESOU__094C9AB2EDCAAB96");

            entity.Property(e => e.ResourceId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdUserDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AD_USER___3214EC27918F8018");
        });

        modelBuilder.Entity<AdUserInGroup>(entity =>
        {
            entity.HasKey(e => e.UserInGroupId).HasName("PK__AD_USER___79C23E6E362E3FEA");
        });

        modelBuilder.Entity<AddonApp>(entity =>
        {
            entity.Property(e => e.AppDate).HasComment("Ngày xuất bản");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AddonAppServer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AllowanceCat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ALLOWANC__3214EC27437855B9");
        });

        modelBuilder.Entity<AllowanceEmployeeAccept>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ALLOWANC__3214EC27CE010FA8");
        });

        modelBuilder.Entity<AllowanceEmployeeMonth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ALLOWANC__3214EC274F22F1BD");
        });

        modelBuilder.Entity<AllowanceEmployeeParam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ALLOWANC__3214EC27E3B2BDC2");
        });

        modelBuilder.Entity<AllowanceParam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ALLOWANC__3214EC27FFAD19B5");
        });

        modelBuilder.Entity<AppMeeting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__APP_MEET__3214EC27396204B2");
        });

        modelBuilder.Entity<AppVendor>(entity =>
        {
            entity.HasKey(e => e.VendorCode).HasName("PK__APP_VEND__E99CB38508933510");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AseanDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DOCUMENT__3214EC2735F22751");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASP_NET___3214EC2787E46112");
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASP_NET___3214EC2778DCE8EE");
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASP_NET___3214EC2779D0BF4E");
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASP_NET___3214EC27AD630955");
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey }).HasName("PK__ASP_NET___E393925EE28B8130");
        });

        modelBuilder.Entity<AspNetUserRole>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId }).HasName("PK__ASP_NET___C612A6DD9C4863F0");
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name }).HasName("PK__ASP_NET___FDB65D76B6104F3D");
        });

        modelBuilder.Entity<AspNetUsersTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASP_NET___3214EC27540B7961");
        });

        modelBuilder.Entity<Asset>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__ASSET__B7ED7EEF9958EB97");
        });

        modelBuilder.Entity<AssetActivity>(entity =>
        {
            entity.HasKey(e => e.ActivityId).HasName("PK__ASSET_AC__8E43DA628944258F");
        });

        //modelBuilder.Entity<AssetAllocateDetail>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__URENCO_A__F82BD2369DC7DDCF_copy1");
        //});

        modelBuilder.Entity<AssetAllocateFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MATERIAL__3214EC270F824689_copy1");
        });

        //modelBuilder.Entity<AssetAllocateHeader>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ASSET_AL__3214EC277E1F7014");
        //});

        //modelBuilder.Entity<AssetAttrGalaxy>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ASSET_AT__3214EC2708E7D473");
        //});

        //modelBuilder.Entity<AssetAttribute>(entity =>
        //{
        //    entity.HasKey(e => e.AttrId).HasName("PK__ASSET_AT__60E3791E1C5231C2");
        //});

        //modelBuilder.Entity<AssetBuyDetail>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ASSET_BU__3214EC27B1E6EB21");
        //});

        //modelBuilder.Entity<AssetBuyFile>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ASSET_AL__3214EC270E6D0A0C");
        //});

        //modelBuilder.Entity<AssetBuyHeader>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ASSET_BU__3214EC277BAE64BA");
        //});

        //modelBuilder.Entity<AssetCancelDetail>(entity =>
        //{
        //    entity.HasKey(e => e.AssetId).HasName("PK__ASSET_PR__3214EC27A68B3A1C");
        //});

        //modelBuilder.Entity<AssetCancelFile>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ASSET_LI__3214EC27428C60E4");
        //});

        //modelBuilder.Entity<AssetCancelHeader>(entity =>
        //{
        //    entity.HasKey(e => e.AssetId).HasName("PK__ASSET_PR__3214EC2733DB25D2");

        //    entity.Property(e => e.CancelTime).IsSparse();
        //});

        //modelBuilder.Entity<AssetEntityMapping>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC073025C9F9");
        //});

        //modelBuilder.Entity<AssetGroup>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<AssetImprovementCategory>(entity =>
        //{
        //    entity.HasKey(e => e.CategoryId).HasName("PK__ASSET_IM__E7DA297CFBBA2082");
        //});

        modelBuilder.Entity<AssetImprovementDetail>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__ASSET_IM__B7ED7EEF2D291BE7");
        });

        //modelBuilder.Entity<AssetImprovementFile>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ASSET_IM__3214EC27854770F4");
        //});

        modelBuilder.Entity<AssetImprovementHeader>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__ASSET_IM__7F5E71D6678EB154");
        });

        modelBuilder.Entity<AssetInventoryDetail>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__ASSET_IN__B7ED7EEF5FD0E030");
        });

        modelBuilder.Entity<AssetInventoryFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_CA__3214EC277FFD6D0F");
        });

        modelBuilder.Entity<AssetInventoryHeader>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__ASSET_IN__B7ED7EEF8D97837E");
        });

        modelBuilder.Entity<AssetLiquidationDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_LI__3214EC273012D870");
        });

        modelBuilder.Entity<AssetLiquidationFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_LI__3214EC2728635F40");
        });

        modelBuilder.Entity<AssetLiquidationHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_LI__3214EC27A7C84CD2");
        });

        modelBuilder.Entity<AssetMain>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__ASSET__B7ED7EEF14B10FFA");
        });

        modelBuilder.Entity<AssetMaintenanceCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__ASSET_MA__E7DA297C953600EF");
        });

        modelBuilder.Entity<AssetMaintenanceDetail>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__ASSET_MA__B7ED7EEF7547E186");
        });

        modelBuilder.Entity<AssetMaintenanceFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_MA__3214EC2709F04B06");
        });

        modelBuilder.Entity<AssetMaintenanceHeader>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__ASSET_MA__7F5E71D6D35AA7DE");
        });

        modelBuilder.Entity<AssetRecalledDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_RE__3214EC27B9EFD372");
        });

        modelBuilder.Entity<AssetRecalledFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_RE__3214EC2707610152");
        });

        modelBuilder.Entity<AssetRecalledHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_RE__3214EC27C5A1A5A8");
        });

        modelBuilder.Entity<AssetRecordDeliveryDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RECORD_D__3214EC272F80CFC8");
        });

        modelBuilder.Entity<AssetRecordDeliveryHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RECORD_D__3214EC273FF6A24F");
        });

        modelBuilder.Entity<AssetRecordsPack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RECORDS___3214EC270E91C146");
        });

        modelBuilder.Entity<AssetRecordsPackAttr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RECORDS___3214EC27873A396F");
        });

        modelBuilder.Entity<AssetRecordsPackFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RECORDS___3214EC27A6503168");
        });

        modelBuilder.Entity<AssetReqMaintainceReparrDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_RE__3214EC271C82EBAA");
        });

        modelBuilder.Entity<AssetReqMaintainceReparrFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_RE__3214EC270F56E18B");
        });

        modelBuilder.Entity<AssetReqMaintainceReparrHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_RE__3214EC27006DCA3E");
        });

        modelBuilder.Entity<AssetRptBrokenDetail>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__ASSET_RP__B7ED7EEFB7E33E4B");
        });

        modelBuilder.Entity<AssetRptBrokenFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_RP__3214EC27488B194E");
        });

        modelBuilder.Entity<AssetRptBrokenHeader>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__RPT_BROK__F6FF16281EA6DDD8");
        });

        modelBuilder.Entity<AssetTransferDetail>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__ASSET_TR__B7ED7EEF7B4438B8");
        });

        modelBuilder.Entity<AssetTransferFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_RP__3214EC27C1FD7BDB");
        });

        modelBuilder.Entity<AssetTransferHeader>(entity =>
        {
            entity.HasKey(e => e.AssetId).HasName("PK__ASSET_TR__B7ED7EEF28935D2F");
        });

        modelBuilder.Entity<AssetType>(entity =>
        {
            entity.HasKey(e => e.CatCode).HasName("PK__URENCO_A__F82BD2369DC7DDCF");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AssetZoneAttr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WHS_ZONE__3214EC2779D44BE5");
        });

        modelBuilder.Entity<AssetZoneMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSET_ZO__3214EC271A7BF699");
        });

        modelBuilder.Entity<AssetZoneStruct>(entity =>
        {
            entity.HasKey(e => e.ZoneCode).HasName("PK__WHS_ZONE__DA72D960C0B4B3B5");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AssignMemberToObject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ASSIGN_M__3214EC27F2330D5E");
        });

        modelBuilder.Entity<AttrGalaxy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ATTR_GAL__3214EC272BC6A815");
        });

        modelBuilder.Entity<AttrGalaxyAet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ATTR_GAL__3214EC277E4D5E83");
        });

        modelBuilder.Entity<AttrManager>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ATTR_MAN__3214EC27BEF37404");
        });

        modelBuilder.Entity<AttrManagerGalaxy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ATTR_MAN__3214EC27040782B6");
        });

        modelBuilder.Entity<AttrSetup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ACTIVITY__3214EC273C903420");
        });

        modelBuilder.Entity<BotSocialManagement>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BotSocialSessionLog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CameraRoom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAMERA_R__3214EC271D39061A");
        });

        modelBuilder.Entity<CandidateBasic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CANDIDAT__3214EC27058945A1");
        });

        modelBuilder.Entity<CandidateCvStorage>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CandidateInterview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CANDIDAT__3214EC2750663A57");

            entity.Property(e => e.InterviewDate).HasComment("Ngày tới phỏng vấn");
            entity.Property(e => e.IsPresent).HasComment("Có mặt");
            entity.Property(e => e.Status).HasComment("Trạng thái");
        });

        modelBuilder.Entity<CandidateWorkEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CANDIDAT__3214EC27A60A90DF");
        });

        modelBuilder.Entity<CardAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CARD_ATT__3214EC27E765E172");

            entity.Property(e => e.FileType).HasComment("Type=0(Tệp tin), Type=1(Hình ảnh)");
        });

        modelBuilder.Entity<CardAttachmentCopy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CARD_ATT__3214EC273A22938E");

            entity.Property(e => e.FileType).HasComment("Type=0(Tệp tin), Type=1(Hình ảnh)");
        });

        modelBuilder.Entity<CardCommentList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CARD_COM__3214EC2723FB9065");
        });

        modelBuilder.Entity<CardItemCheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CARD_ITE__3214EC27D649B3C6");
        });

        modelBuilder.Entity<CardItemCheckTrackingProgress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CARD_ITE__3214EC277BA4C77F");
        });

        modelBuilder.Entity<CardMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CARD_MAP__3214EC272FA1387E");

            entity.Property(e => e.BoardCode).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CardProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CARD_PRO__3214EC27716CA8B4");
        });

        modelBuilder.Entity<CardSubitemCheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CARD_SUB__3214EC279B410C96");
        });

        modelBuilder.Entity<CardUserActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CARD_USE__3214EC2779CBB941");
        });

        modelBuilder.Entity<CareerCatScale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAREER_C__3214EC07BFC6DB06");
        });

        modelBuilder.Entity<CatActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAT_ACTI__3214EC27743A8010");
        });

        modelBuilder.Entity<CatWorkFlow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAT_OBJE__3214EC27826FB70A");
        });

        modelBuilder.Entity<CategoryCareer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CATEGORY__3214EC076DEFE7FC");
        });

        modelBuilder.Entity<CategoryWorksheet>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ChatGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PROJECT___3214EC2728591718");

            entity.Property(e => e.Id).HasComment("Customer Id");
        });

        modelBuilder.Entity<ChatHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GROUP_CH__3214EC27CA9415A4");

            entity.Property(e => e.Id).HasComment("Customer Id");
        });

        modelBuilder.Entity<CmsAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_atta__3213E83F628FA481");
        });

        modelBuilder.Entity<CmsCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_cate__3213E83F656C112C");

            entity.Property(e => e.Published).HasDefaultValueSql("((0))");
            entity.Property(e => e.Trash).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CmsComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_comm__3213E83F68487DD7");

            entity.Property(e => e.Published).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CmsExtraField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_extr__3213E83F6B24EA82");

            entity.Property(e => e.Published).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CmsExtraFieldsGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_extr__3213E83F6E01572D");
        });

        modelBuilder.Entity<CmsExtraFieldsValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_extr__3213E83F70DDC3D8");

            entity.Property(e => e.FieldGroup).HasComment("Vị trí");
            entity.Property(e => e.FieldValue).HasComment("Tiêu đề");
            entity.Property(e => e.Ordering).HasComment("Thứ tự");
            entity.Property(e => e.Publish).HasDefaultValueSql("((0))");
            entity.Property(e => e.Trash).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CmsFunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_func__3213E83F797309D9");
        });

        modelBuilder.Entity<CmsFunctionGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_func__3213E83F73BA3083");

            entity.Property(e => e.Add).HasDefaultValueSql("((0))");
            entity.Property(e => e.Delete).HasDefaultValueSql("((0))");
            entity.Property(e => e.Full).HasDefaultValueSql("((0))");
            entity.Property(e => e.Update).HasDefaultValueSql("((0))");
            entity.Property(e => e.View).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CmsFunctionResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_func__3213E83F76969D2E");
        });

        modelBuilder.Entity<CmsItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_item__3213E83F7C4F7684");

            entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.DatePost).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FeaturedOrdering).HasDefaultValueSql("((0))");
            entity.Property(e => e.Hits).HasDefaultValueSql("((0))");
            entity.Property(e => e.Published).HasDefaultValueSql("((0))");
            entity.Property(e => e.Trash).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CmsRating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_rati__3213E83F7F2BE32F");
        });

        modelBuilder.Entity<CmsRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_role__3213E83F02084FDA");
        });

        modelBuilder.Entity<CmsSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_sett__3213E83F04E4BC85");

            entity.Property(e => e.Published).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<CmsTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_tags__3213E83F07C12930");

            entity.Property(e => e.Published).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CmsTagsXref>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_tags__3213E83F0A9D95DB");
        });

        modelBuilder.Entity<CoinRateExchange>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CommAttribute>(entity =>
        {
            entity.HasKey(e => e.CommId).HasName("PK__COMM_ATT__AF8CE2B9395AF137");

            entity.Property(e => e.CommId).HasComment("Customer Id");
        });

        modelBuilder.Entity<CommitmentDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CommitmentHeader>(entity =>
        {
            entity.Property(e => e.CreateBy).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UpdateBy).IsFixedLength();
        });

        modelBuilder.Entity<CommonSetting>(entity =>
        {
            entity.Property(e => e.AssetCode).HasComment("Asset_code ==null không được quản lý");
            entity.Property(e => e.SettingId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CommonSettingArticle>(entity =>
        {
            entity.HasKey(e => e.CodeSet).HasName("PK__COMMON_S__09D346AC13AE7E78");

            entity.Property(e => e.AssetCode).HasComment("Asset_code ==null không được quản lý");
            entity.Property(e => e.SettingId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CommonSettingCategory>(entity =>
        {
            entity.HasKey(e => e.SettingId).HasName("PK__COMMON_S__137118B0C81CB8C8");

            entity.Property(e => e.AssetCode).HasComment("Asset_code ==null không được quản lý");
        });

        modelBuilder.Entity<CommonSettingCategoryCopy>(entity =>
        {
            entity.HasKey(e => e.SettingId).HasName("PK__COMMON_S__137118B049C55D20");

            entity.Property(e => e.AssetCode).HasComment("Asset_code ==null không được quản lý");
        });

        modelBuilder.Entity<CommonSettingGroup>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CompanyRuleItem>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CompanyScheduleWork>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_WORK___3214EC27BEA3A41C");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CONTACT__3214EC27CCE39216");

            entity.Property(e => e.Id).HasComment("Contact Id");
            entity.Property(e => e.Address).HasComment("Address");
            entity.Property(e => e.ContactName).HasComment("Contact Name");
            entity.Property(e => e.CreateTime).HasComment("Create time");
            entity.Property(e => e.CusCode).HasComment("Customer Code");
            entity.Property(e => e.Email).HasComment("Email");
            entity.Property(e => e.Facebook).HasComment("Facebook");
            entity.Property(e => e.Fax).HasComment("Fax");
            entity.Property(e => e.Flag).HasComment("Flag");
            entity.Property(e => e.GooglePlus).HasComment("Google Plus");
            entity.Property(e => e.Image).HasComment("Image");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("('')");
            entity.Property(e => e.MobilePhone).HasComment("Mobile Phone");
            entity.Property(e => e.Note).HasComment("Note");
            entity.Property(e => e.Skype).HasComment("Skype");
            entity.Property(e => e.SuppCode).HasComment("Supplier Code");
            entity.Property(e => e.Telephone).HasComment("Telephone");
            entity.Property(e => e.Twitter).HasComment("Twitter");
            entity.Property(e => e.UpdateTime).HasComment("Update time");
            entity.Property(e => e.UserId).HasComment("User Id");
        });

        modelBuilder.Entity<ContractActivity>(entity =>
        {
            entity.HasKey(e => e.ContractActivityId).HasName("PK__CONTRACT__62A7B88D0A2E7944");

            entity.Property(e => e.ContractActivityId).HasComment("Customer Id");
        });

        modelBuilder.Entity<ContractAttribute>(entity =>
        {
            entity.HasKey(e => e.ContractAttributeId).HasName("PK__CONTRACT__CA96A4AB25247E62");

            entity.Property(e => e.ContractAttributeId).HasComment("Customer Id");
        });

        modelBuilder.Entity<ContractAttributeHi>(entity =>
        {
            entity.HasKey(e => e.ContractAttributeId).HasName("PK__CONTRACT__CA96A4AB9782DD0D");

            entity.Property(e => e.ContractAttributeId).HasComment("Customer Id");
        });

        modelBuilder.Entity<ContractDetail>(entity =>
        {
            entity.HasKey(e => e.ContractDetailId).HasName("PK__CONTRACT__97300B5EC14C7251");

            entity.Property(e => e.ContractDetailId).HasComment("Customer Id");
        });

        modelBuilder.Entity<ContractFile>(entity =>
        {
            entity.HasKey(e => e.ContractFileId).HasName("PK__CONTRACT__3B4129874B52EC11");

            entity.Property(e => e.ContractFileId).HasComment("Customer Id");
        });

        modelBuilder.Entity<ContractMemberTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CONTRACT__3214EC27901711F1");

            entity.Property(e => e.Id).HasComment("Customer Id");
        });

        modelBuilder.Entity<ContractNote>(entity =>
        {
            entity.HasKey(e => e.ContractNoteId).HasName("PK__CONTRACT__7053D99890BA7362");

            entity.Property(e => e.ContractNoteId).HasComment("Customer Id");
        });

        modelBuilder.Entity<ContractPeopleTag>(entity =>
        {
            entity.HasKey(e => e.ContractPeopleTagId).HasName("PK__CONTRACT__F5AE16F41828598F");

            entity.Property(e => e.ContractPeopleTagId).HasComment("Customer Id");
        });

        modelBuilder.Entity<ContractSchedulePay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CONTRACT__809C800AEC3C5676");

            entity.Property(e => e.Id).HasComment("Customer Id");
        });

        modelBuilder.Entity<ContractSchedulePayHi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CONTRACT__3214EC27F328931F");

            entity.Property(e => e.Id).HasComment("Customer Id");
        });

        modelBuilder.Entity<ContractServiceDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CONTRACT__3214EC27EFB9D256");

            entity.Property(e => e.Id).HasComment("Customer Id");
            entity.Property(e => e.CustomFee).HasComment("CHIẾT KHẤU");
            entity.Property(e => e.Discount).HasComment("GIẢM GIÁ");
        });

        modelBuilder.Entity<ContractServiceDetailHi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CONTRACT__3214EC2700DAAE1B");

            entity.Property(e => e.Id).HasComment("Customer Id");
            entity.Property(e => e.CustomFee).HasComment("CHIẾT KHẤU");
            entity.Property(e => e.Discount).HasComment("GIẢM GIÁ");
        });

        modelBuilder.Entity<CostTableLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__COST_TAB__3214EC278E3B88AD");

            entity.Property(e => e.PriceCostAirline).HasComment("Giá đại lý đường bay");
            entity.Property(e => e.PriceCostCatelogue).HasComment("Giá đại lý catalogue");
            entity.Property(e => e.PriceCostSea).HasComment("Giá đại lý đường biển");
            entity.Property(e => e.PriceRetailBuild).HasComment("Giá bán lẻ có thi công");
            entity.Property(e => e.PriceRetailBuildAirline).HasComment("Giá bán lẻ có thi công bay");
            entity.Property(e => e.PriceRetailBuildSea).HasComment("Giá bán lẻ có thi công kho,biển");
            entity.Property(e => e.PriceRetailNoBuild).HasComment("Giá bán lẻ không thi công");
            entity.Property(e => e.PriceRetailNoBuildAirline).HasComment("Giá bán lẻ không thi công bay");
            entity.Property(e => e.PriceRetailNoBuildSea).HasComment("Giá bán lẻ không thi công kho, biển");
        });

        modelBuilder.Entity<CrawlerBotManagement>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrawlerDomainConfiguration>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrawlerDomainConfigurationParam>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrawlerJobSchedule>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrawlerKeyword>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrawlerRunningLog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrawlerSessionContentResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CRAWLER_SESSION_CONTENT_RESULT_1");
        });

        modelBuilder.Entity<CrawlerSocialNetworkParam>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CriteriaRecruitmentAttrDatum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CriteriaRecruitmentCat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CRITERIA__3214EC27E6430169");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CusId).HasName("PK__CUSTOMER__373A37B716954C4D");

            entity.Property(e => e.CusId).HasComment("Customer Id");
            entity.Property(e => e.ActivityStatus).HasComment("Activity Status");
            entity.Property(e => e.Address).HasComment("Address");
            entity.Property(e => e.CusCode).HasComment("Customer Code");
            entity.Property(e => e.CusGroup).HasComment("Customer Group");
            entity.Property(e => e.CusName).HasComment("Customer Name");
            entity.Property(e => e.Description).HasComment("Description");
            entity.Property(e => e.Email).HasComment("Email");
            entity.Property(e => e.Fax).HasComment("Fax");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("((1))")
                .HasComment("Flag");
            entity.Property(e => e.IconLevel).HasComment("ICON LEVEL CODE");
            entity.Property(e => e.LotName).HasComment("Birthday");
            entity.Property(e => e.MobilePhone).HasComment("MobilePhone");
            entity.Property(e => e.PersonInCharge).HasComment("Người phụ trách");
            entity.Property(e => e.Telephone).HasComment("Telephone");
        });

        modelBuilder.Entity<CustomerAppointment>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CustomerAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUSTOMER__3214EC2721BC1C11");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CustomerExtend>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUSTOMER__3213E83FE0B913DB");

            entity.Property(e => e.Id).HasComment("Id");
            entity.Property(e => e.CreatedTime).HasComment("Create Time");
            entity.Property(e => e.CustomerId).HasComment("Customer Id");
            entity.Property(e => e.ExtCode).HasComment("Extend Id");
            entity.Property(e => e.Flag).HasComment("Flag");
            entity.Property(e => e.UpdatedTime).HasComment("Update Time");
        });

        modelBuilder.Entity<CustomerFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUSTOMER__3214EC27B3E75470");
        });

        modelBuilder.Entity<CustomerReminder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUSTOMER__3214EC279F291F7B");
        });

        modelBuilder.Entity<DashboardDataJson>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DASHBOAR__3214EC27420774B8");
        });

        modelBuilder.Entity<DashboardDataJsonCopy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DASHBOAR__3214EC272960E3FB");
        });

        modelBuilder.Entity<DbVAmchartSocialSessionLog>(entity =>
        {
            entity.ToView("db.V_AMCHART_SOCIAL_SESSION_LOG");
        });

        modelBuilder.Entity<DecisionBonusDisciplineDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DECISION__3214EC2733A44F27");
        });

        modelBuilder.Entity<DecisionBonusDisciplineHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DECISION__3214EC27BD7038F2");
        });

        modelBuilder.Entity<DecisionMovementDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DECISION__3214EC276F3F0F43");
        });

        modelBuilder.Entity<DecisionMovementHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DECISION__3214EC27DAAA02B0");
        });

        modelBuilder.Entity<DeviceMeetingControl>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DispatchesCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DISPATCH__3214EC278779E683");
        });

        modelBuilder.Entity<DispatchesCommentAct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DISPATCH__3214EC2740D8AAC5");
        });

        modelBuilder.Entity<DispatchesFilesAct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DISPATCH__3214EC278296623E");
        });

        modelBuilder.Entity<DispatchesHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DISPATCH__3214EC273934AFC6");
        });

        modelBuilder.Entity<DispatchesMemberActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DISPATCH__3214EC27E208F6DB");
        });

        modelBuilder.Entity<DispatchesTrackingProcess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DISPATCH__3214EC273E7311B8");
        });

        modelBuilder.Entity<DispatchesUser>(entity =>
        {
            entity.HasKey(e => e.GroupUserCode).HasName("PK__DISPATCH__707D788F6E45E7B7");
        });

        modelBuilder.Entity<DispatchesWeekWorkingScheduler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DISPATCH__3214EC273583AC45");
        });

        modelBuilder.Entity<DynamicRegistSurvey>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DynamicRegistSurveyDatum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DynamicSurveyUser>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EdmsAudioBook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_AUD__3214EC27754CCB16");
        });

        modelBuilder.Entity<EdmsBox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_BOX__3214EC2744F1725C");
        });

        modelBuilder.Entity<EdmsBoxFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_BOX__3214EC2782B5A1AC");
        });

        modelBuilder.Entity<EdmsBoxTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_BOX__3214EC2790013E85");
        });

        modelBuilder.Entity<EdmsCatRepoSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_CAT__3214EC27353DDB1D");
        });

        modelBuilder.Entity<EdmsCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_CAT__3214EC27316D4A39");
        });

        modelBuilder.Entity<EdmsEntityMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_ENT__3214EC07976087E3");
        });

        modelBuilder.Entity<EdmsEntityMappingAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_ENT__3214EC075E5CE1B3");
        });

        modelBuilder.Entity<EdmsEntityMappingDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_ENT__3214EC071647BDD6");
        });

        modelBuilder.Entity<EdmsFile>(entity =>
        {
            entity.Property(e => e.FileId)
                .ValueGeneratedOnAdd()
                .HasComment("Customer Id");
        });

        modelBuilder.Entity<EdmsFilePackCover>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OBJECTIV__3214EC2752EA176C");
        });

        modelBuilder.Entity<EdmsFilePackCoverAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_FIL__3214EC27479009C0");
        });

        modelBuilder.Entity<EdmsFilePermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PK__EDMS_FIL__EB3C611EE97760EE");

            entity.Property(e => e.PermissionId).HasComment("Customer Id");
        });

        modelBuilder.Entity<EdmsFloor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_FLO__3214EC27C7749C40");
        });

        modelBuilder.Entity<EdmsFloorAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_FLO__3214EC27C6B43189");
        });

        modelBuilder.Entity<EdmsFloorDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_FLO__3214EC272B50CC77");
        });

        modelBuilder.Entity<EdmsLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_LIN__3214EC27B1D7E8CB");
        });

        modelBuilder.Entity<EdmsLineAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_LIN__3214EC27426EB753");
        });

        modelBuilder.Entity<EdmsLineDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_LIN__3214EC272577A469");
        });

        modelBuilder.Entity<EdmsMoveBoxLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_MOV__3214EC275C283495");
        });

        modelBuilder.Entity<EdmsMoveBoxLogDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_MOV__3214EC27F17317A4");
        });

        modelBuilder.Entity<EdmsMoveProductLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_MOV__3214EC27FA9839A4");
        });

        modelBuilder.Entity<EdmsObjectShareFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FILE_OBJ__3214EC27DFFF8906_copy1");
        });

        modelBuilder.Entity<EdmsRack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_RAC__3214EC27B7A9ACBE");
        });

        modelBuilder.Entity<EdmsRackAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_RAC__3214EC27C0466C8A");
        });

        modelBuilder.Entity<EdmsRackDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_RAC__3214EC270A018663");
        });

        modelBuilder.Entity<EdmsReceiptExportFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REC__3214EC27B6F2BF9B");
        });

        modelBuilder.Entity<EdmsReceiptExportStore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REC__3214EC074929FCCB");
        });

        modelBuilder.Entity<EdmsReceiptInputFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REC__3214EC27025EB842");
        });

        modelBuilder.Entity<EdmsReceiptInputStore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REC__3214EC07DE13F52A");
        });

        modelBuilder.Entity<EdmsRemove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REM__3214EC27E39B7A27");
        });

        modelBuilder.Entity<EdmsRemoveBox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REM__3214EC27A772694E");
        });

        modelBuilder.Entity<EdmsRepoCatFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REP__3214EC273CDEFCE5");
        });

        modelBuilder.Entity<EdmsRepoDefaultObject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REP__3214EC27DCAAA8A3");
        });

        modelBuilder.Entity<EdmsRepository>(entity =>
        {
            entity.HasKey(e => e.ReposId).HasName("PK__EDMS_REP__B9E464AF38BD7B5C_copy1");

            entity.Property(e => e.ReposId).HasComment("Customer Id");
            entity.Property(e => e.PassWord).UseCollation("SQL_Latin1_General_CP850_BIN");
        });

        modelBuilder.Entity<EdmsRequestEndBox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REQ__3214EC078350DBA9");
        });

        modelBuilder.Entity<EdmsRequestExportFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REQ__3214EC2707443E12");
        });

        modelBuilder.Entity<EdmsRequestExportStore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REQ__3214EC078506BA69");
        });

        modelBuilder.Entity<EdmsRequestFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REQ__3214EC27E9EA2745");
        });

        modelBuilder.Entity<EdmsRequestInputFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REQ__3214EC272C1E56E6");
        });

        modelBuilder.Entity<EdmsRequestInputStore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REQ__3214EC070314C6BC");
        });

        modelBuilder.Entity<EdmsRequestTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_REQ__3214EC2724BB3B06");
        });

        modelBuilder.Entity<EdmsTermite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_TER__3214EC2718C225BA");
        });

        modelBuilder.Entity<EdmsTermiteBox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_TER__3214EC27A30F3F37");
        });

        modelBuilder.Entity<EdmsTimeOfDocumentPreservation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_TIM__3214EC27B33ECD82");
        });

        modelBuilder.Entity<EdmsTimeOfDocumentPreservationCommon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_TIM__3214EC27242E6D08");
        });

        modelBuilder.Entity<EdmsWarehouse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_WAR__3214EC271D0C9EB3");

            entity.Property(e => e.Type).HasComment("PRODUCT(PR), RECORD_VOUCHER (RV)");
        });

        modelBuilder.Entity<EdmsWarehouseAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_WAR__3214EC2773543982");

            entity.Property(e => e.Type).HasComment("PRODUCT(PR), RECORD_VOUCHER (RV)");
        });

        modelBuilder.Entity<EdmsWarehouseDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_WAR__3214EC27F3BAB4FC");

            entity.Property(e => e.Type).HasComment("PRODUCT(PR), RECORD_VOUCHER (RV)");
        });

        modelBuilder.Entity<EdmsWarehouseExtend>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_WAR__3214EC273E035016");
        });

        modelBuilder.Entity<EdmsWarehouseMedium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_WAR__3214EC27BE273B25");
        });

        modelBuilder.Entity<EdmsWarehouseUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_WAR__3214EC2764F89795");
        });

        modelBuilder.Entity<EdmsWhsMedium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_WHS__3214EC276DAA2FFB");
        });

        modelBuilder.Entity<EdmsWhsQrcode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_WHS__3214EC0712859372");
        });

        modelBuilder.Entity<EdmsWhsQrcodeAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_WHS__3214EC075F587B62");
        });

        modelBuilder.Entity<EdmsWhsQrcodeDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDMS_WHS__3214EC072EBF814C");
        });

        modelBuilder.Entity<EduCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CATEGORY__3213E83FCB6C5079");

            entity.Property(e => e.Published).HasDefaultValueSql("((0))");
            entity.Property(e => e.Trash).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<EduExamination>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasComment("Customer Id");
        });

        modelBuilder.Entity<EduExaminationDetail>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasComment("Customer Id");
        });

        modelBuilder.Entity<EduExtraFieldGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDU_EXTR__3213E83FC9B4F19A");
        });

        modelBuilder.Entity<EduLecture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cms_item__3213E83F8BEE0CE4");

            entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.DatePost).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FeaturedOrdering).HasDefaultValueSql("((0))");
            entity.Property(e => e.Hits).HasDefaultValueSql("((0))");
            entity.Property(e => e.Published).HasDefaultValueSql("((0))");
            entity.Property(e => e.Trash).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<EmployeeCertificate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<EmployeeCoaching>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EMPLOYEE__3214EC2730FF908A");
        });

        modelBuilder.Entity<EmployeeStatusTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EMPLOYEE__3214EC27352C12CF");
        });

        modelBuilder.Entity<EntityMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ENTITY_M__3214EC274940AF25");
        });

        modelBuilder.Entity<ExcuterControlRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EXCUTER___3214EC27A0784278");
        });

        modelBuilder.Entity<ExcuterControlRoleInst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EXCUTER___3214EC270BA919E2");
        });

        modelBuilder.Entity<FaceFaceId>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FACE_FAC__3214EC27ED39232E");
        });

        modelBuilder.Entity<FacoProductCat>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__FACO_PRO__52B41763CAF69487");

            entity.Property(e => e.ProductId).HasComment("Customer Id");
        });

        modelBuilder.Entity<FcmToken>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__FCM_TOKE__F3BEEBFFEC6A585D");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<FileObjectShare>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FILE_OBJ__3214EC27DFFF8906");
        });

        modelBuilder.Entity<FileRecruitment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FILE_REC__3214EC27377AAF63");
        });

        modelBuilder.Entity<FileVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ACTIVITY__3214EC2709860C47");
        });

        modelBuilder.Entity<FilesShareObjectUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FILES_SH__3214EC27B5E2CFDB");
        });

        modelBuilder.Entity<ForecastProductInStock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FORECAST__3214EC27D4919108");
        });

        modelBuilder.Entity<FormCat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FORM_CAT__3214EC279FB3790E");
        });

        modelBuilder.Entity<FormControl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FORM_CON__3214EC270EC0406A");
        });

        modelBuilder.Entity<FundAccEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FUND_ACC__3214EC2791F72918");

            entity.Property(e => e.Status).HasComment("CREATED,CANCEL,PENDING,REFUSE,ACCEPT");
        });

        modelBuilder.Entity<FundAccEntryTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FUND_ACC__3214EC273CE30B07");
        });

        modelBuilder.Entity<FundCatReptExp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FUND_CAT__3214EC271DD79740");
        });

        modelBuilder.Entity<FundCurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FUND_CUR__3214EC27916220C8");
        });

        modelBuilder.Entity<FundExchangeRate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FUND_EXC__3214EC27E8B95DC1");

            entity.Property(e => e.DeletedTime).HasComment("0");
        });

        modelBuilder.Entity<FundExchangeRateCopy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FUND_EXC__3214EC2758178C88");

            entity.Property(e => e.DeletedTime).HasComment("0");
        });

        modelBuilder.Entity<FundFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FUND_FIL__3214EC276BFE8745");
        });

        modelBuilder.Entity<FundLoadingSmsBank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOADING___3214EC279F687AE1");
        });

        modelBuilder.Entity<FundRelativeObjMng>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FUND_REL__3214EC27430223BE");
        });

        modelBuilder.Entity<GalaxyKeyword>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GALAXY_K__3214EC27F3EF0C2D");

            entity.Property(e => e.Id).HasComment("Customer Id");
        });

        modelBuilder.Entity<GetCountCardWork>(entity =>
        {
            entity.ToView("GET_COUNT_CARD_WORK");
        });

        modelBuilder.Entity<HolidayDate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HOLIDAY___3214EC27CF4DF0CC");
        });

        modelBuilder.Entity<HrAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HR_ADDRE__3213E83F3C0580D8");
        });

        modelBuilder.Entity<HrContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HR_CONTA__3213E83FF0D459DE");
        });

        modelBuilder.Entity<HrContract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HR_CONTR__3213E83FD8598162");

            entity.Property(e => e.Allowance).HasComment("Phụ cấp");
            entity.Property(e => e.Bonus).HasComment("Tiền thưởng");
            entity.Property(e => e.ContractType).HasComment("Loại hợp đồng");
            entity.Property(e => e.DateOfLaborBook).HasComment("Ngày cấp sổ lao động");
            entity.Property(e => e.DatesOfPay).HasComment("Ngày thanh toán");
            entity.Property(e => e.EmployeeId).HasComment("Mã nhân viên");
            entity.Property(e => e.ExpTimeWork).HasComment("Thời gian làm việc");
            entity.Property(e => e.InfoContract).HasComment("Thông tin hợp đồng");
            entity.Property(e => e.InfoInsuarance).HasComment("Thông tin bảo hiểm");
            entity.Property(e => e.Insuarance).HasComment("Bảo hiểm");
            entity.Property(e => e.OtherAgree).HasComment("Thỏa thuận khác");
            entity.Property(e => e.Payment).HasComment("Thanh toán");
            entity.Property(e => e.PlaceLaborBook).HasComment("Nơi cấp sổ lao động");
            entity.Property(e => e.PlaceWork).HasComment("Nơi làm việc");
            entity.Property(e => e.Salary).HasComment("Lương");
            entity.Property(e => e.SalaryRatio).HasComment("Bậc lương");
            entity.Property(e => e.Signer).HasComment("Người ký");
            entity.Property(e => e.ToolsWork).HasComment("Công cụ làm việc");
            entity.Property(e => e.TypeMoney).HasComment("Kiểu tiền");
            entity.Property(e => e.WorkContent).HasComment("Nội dung công việc");
        });

        modelBuilder.Entity<HrEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HR_EMPLO__3214EC0731C319E4");

            entity.Property(e => e.Id).HasComment("id - Id");
            entity.Property(e => e.Accountholder).HasComment("Chủ tài khoản - AccountHolder");
            entity.Property(e => e.Accountnumber).HasComment("Số tài khoản - AccountNumber");
            entity.Property(e => e.Accountopenplace).HasComment("Nơi mở tài khoản - AccountOpenPlace");
            entity.Property(e => e.Bank).HasComment("Ngân hàng - Bank");
            entity.Property(e => e.Birthday).HasComment("Ngày sinh - Birthday");
            entity.Property(e => e.Birthofplace).HasComment("Nguyên quán - BirthOfPlace");
            entity.Property(e => e.Computerskill).HasComment("Trình độ tin học - ComputerSkill");
            entity.Property(e => e.Disciplines).HasComment("Ngành học - Disciplines");
            entity.Property(e => e.Educationallevel).HasComment("Trình độ văn hóa - EducationalLevel");
            entity.Property(e => e.Emailpassword).HasComment("EmailPassword");
            entity.Property(e => e.Emailuser).HasComment("EmailUser");
            entity.Property(e => e.Employeegroup).HasComment("1: Nhân viên\r\n2: Giáo viên\r\n3: Gia sư\r\n4: Thực tập - EmployeeGroup");
            entity.Property(e => e.Employeekind).HasComment("Loại hình nhân viên - EmployeeKind");
            entity.Property(e => e.Employeetype).HasComment("Kiểu nhân viên - EmployeeType");
            entity.Property(e => e.Factiondate).HasComment("Ngày vào đảng - FactionDate");
            entity.Property(e => e.Fullname).HasComment("Họ vs tên - FullName");
            entity.Property(e => e.Gender).HasComment("Giới tính - Gender");
            entity.Property(e => e.Health).HasComment("Sức khẻo - Health");
            entity.Property(e => e.Identification).HasComment("Nhận dạng - Identification");
            entity.Property(e => e.Identitycard).HasComment("Chứng minh nhân dân - IdentityCard");
            entity.Property(e => e.Identitycarddate).HasComment("Ngày cấp chứng minh thư - IdentityCardDate");
            entity.Property(e => e.Identitycardplace).HasComment("Nới cấp chứng minh thư - IdentityCardPlace");
            entity.Property(e => e.Languagelevel).HasComment("Trình độ ngoại ngử - LanguageLevel");
            entity.Property(e => e.Maritalstatus).HasComment("Tình trạng hôn nhân - MaritalStatus");
            entity.Property(e => e.Nation).HasComment("Dân tộc - Nation");
            entity.Property(e => e.Nationlaty).HasComment("Quốc tịch - Nationlaty");
            entity.Property(e => e.Nickname).HasComment("Tên thường dùng - NickName");
            entity.Property(e => e.Permanentresidence).HasComment("Hộ khẩu thường trú - PermanentResidence");
            entity.Property(e => e.Phone).HasComment("Số điện thoại - Phone");
            entity.Property(e => e.Picture).HasComment("Id Hình ảnh - Picture");
            entity.Property(e => e.Position).HasComment("Chức vụ - Position");
            entity.Property(e => e.Religion).HasComment("Tôn giáo - Religion");
            entity.Property(e => e.Salaryfactor).HasComment("Hệ số lương - SalaryFactor");
            entity.Property(e => e.Salarygroup).HasComment("Nhóm lương - SalaryGroup");
            entity.Property(e => e.Salarytype).HasComment("Loại lương - SalaryType");
            entity.Property(e => e.Socialinsurance).HasComment("Số bảo hiểm xã hội - SocialInsurance");
            entity.Property(e => e.Socialinsurancedate).HasComment("Ngày cấp bảo hiểm xa hội - SocialInsuranceDate");
            entity.Property(e => e.Socialinsuranceplace).HasComment("Nơi cấp bảo hiểm xã hội - SocialInsurancePlace");
            entity.Property(e => e.Specialized).HasComment("Chuyên ngành - Specialized");
            entity.Property(e => e.Status).HasComment("Trạng thái - Status");
            entity.Property(e => e.Taxcode).HasComment("Mã số thuế - TaxCode");
            entity.Property(e => e.Trainingschool).HasComment("Trường đào tạo - TrainingSchool");
            entity.Property(e => e.Trainingtime).HasComment("Thời gian đào tạo - TrainingTime");
            entity.Property(e => e.Trainingtype).HasComment(" TrainingType");
            entity.Property(e => e.Unit).HasComment("Đơn vị - Unit");
            entity.Property(e => e.Wage).HasComment("Bậc lương - Wage");
            entity.Property(e => e.YearsOfExp).HasComment("năm kinh nghiêm");
        });

        //modelBuilder.Entity<HrEmployeeDecision>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__HR_EMPLO__3214EC2709A0E6F8");

        //    entity.Property(e => e.Style).HasComment("1- Chấm dứt hợp đồng\r\n2- Điều động nhân sự\r\n3- Chuyển phong ban nhân sự");
        //});

        //modelBuilder.Entity<HrEmployeeMobilization>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__HR_EMPLO__3214EC27755CD5D7");
        //});

        modelBuilder.Entity<HrRomoocDriver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HR_ROMOO__3214EC076DD7916A");
        });

        //modelBuilder.Entity<HrTrainingCourse>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__HR_TRAIN__3213E83F24F9369A");
        //});

        //modelBuilder.Entity<HrTranningCourseFile>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__HR_TRANN__3214EC279B68A838");
        //});

        modelBuilder.Entity<HrWorkflow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HR_WORKF__3213E83F1E2AC5B0");
        });

        //modelBuilder.Entity<HrWorkingProcess>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__HR_WORKI__3213E83FF4D8C73D");
        //});

        modelBuilder.Entity<IotAnalysisAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IOT_ANAL__3214EC27033A52F5");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        //modelBuilder.Entity<IotCarInOut>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__IOT_CAR___3214EC27DBDC0E07");
        //});

        //modelBuilder.Entity<IotDeviceInfo>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__IOT_DEVI__3214EC27EB5DDEE4");
        //});

        //modelBuilder.Entity<IotSensor>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__IOT_SENS__3214EC2731C068A2");
        //});

        //modelBuilder.Entity<IotSetUpAlert>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__IOT_SET___3214EC27262DBE5C");
        //});

        //modelBuilder.Entity<IotWarningSetting>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__IOT_WARN__3214EC27DC3648FB");

        //    entity.Property(e => e.Id).ValueGeneratedNever();
        //});

        //modelBuilder.Entity<ItemPackUser>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<JcObjectIdRelative>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__JC_OBJEC__3214EC27694875C2");

        //    entity.Property(e => e.Weight).HasDefaultValueSql("((0))");
        //});

        modelBuilder.Entity<JcObjectIdRelative100k>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JC_OBJEC__3214EC272E65C63C");

            entity.Property(e => e.Weight).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<JcObjectIdRelativeSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JC_OBJEC__3214EC27BF9606DA");

            entity.Property(e => e.Weight).HasDefaultValueSql("((0))");
        });

        //modelBuilder.Entity<JcObjectType>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__JC_OBJEC__3214EC27325AFD71");
        //});

        //modelBuilder.Entity<JcProduct>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__JC_PRODU__3214EC27973BE687");
        //});

        //modelBuilder.Entity<JcService>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__JC_SERVI__3214EC27E294F320");
        //});

        //modelBuilder.Entity<JcTrackingBuilding>(entity =>
        //{
        //    entity.HasKey(e => e.JctCode).HasName("PK__JC_TRACK__60F1FA5BFB71B856");

        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        modelBuilder.Entity<JcTrackingMedium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JC_TRACK__3214EC27D92A0F03");
        });

        //modelBuilder.Entity<JckMaterialsComsume>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__JCK_MATE__3214EC27D4EB7464");
        //});

        //modelBuilder.Entity<JobCardAssignee>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__JOB_CARD__3214EC279DA8E93F");
        //});

        //modelBuilder.Entity<JobcardDataLogger>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__JOBCARD___3214EC2766DF1824");
        //});

        //modelBuilder.Entity<JobcardLink>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__JOBCARD___3214EC276B526F50");
        //});

        //modelBuilder.Entity<KeyWordDataPool>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__KEY_WORD__3214EC278D0B0AC7");
        //});

        //modelBuilder.Entity<LectureDiscuss>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__LECTURE___3214EC2735421096");
        //});

        modelBuilder.Entity<LinkedInDataProfileId>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LinkedInDataProfileUser>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LinkedInInfoDatum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        //modelBuilder.Entity<LmsBoardTask>(entity =>
        //{
        //    entity.Property(e => e.BoardId).ValueGeneratedOnAdd();
        //});

        modelBuilder.Entity<LmsClass>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsCommonSettingCat>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsCommonSettingValue>(entity =>
        {
            entity.Property(e => e.AttrCode).IsFixedLength();
            entity.Property(e => e.AttrValue).IsFixedLength();
            entity.Property(e => e.CreatedBy).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ObjectCode).IsFixedLength();
            entity.Property(e => e.TableName).IsFixedLength();
            entity.Property(e => e.Unit).IsFixedLength();
            entity.Property(e => e.UpdatedBy).IsFixedLength();
        });

        modelBuilder.Entity<LmsCourse>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsExamDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsExamHeader>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsExamScheduler>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsLectureManagement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LMS_LECT__3214EC270650DFCE");
        });

        modelBuilder.Entity<LmsLectureSubjectCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LMS_LECT__3214EC27944CA863");
        });

        modelBuilder.Entity<LmsListTask>(entity =>
        {
            entity.Property(e => e.ListId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsMentorMentee>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsMsgNotification>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsPracticeTestDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsPracticeTestDetail1>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsPracticeTestHeader>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsPracticeTestHeader1>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsQuizLectureSubjectCourse>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsQuizPoolReference>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsSubject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LMS_SUBJ__3214EC27728844D5");
        });

        modelBuilder.Entity<LmsSubjectManagement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LMS_SUBJ__3214EC2796E7917B");
        });

        modelBuilder.Entity<LmsTask>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsTaskActivity>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsTaskCommentList>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsTaskStudentAssign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LMS_TASK__3214EC27713149B3");
        });

        modelBuilder.Entity<LmsTrackDiligence>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsTutoringSchedule>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsUserClass>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsUserMsg>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LmsWithdrawn>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LogChangeDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOG_DOCU__3214EC27BB25747A");
        });

        modelBuilder.Entity<LogMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOG_MESS__3214EC27A0DF12FF");
        });

        modelBuilder.Entity<LotProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOT_PROD__3214EC2766469DF4");

            entity.Property(e => e.ManufactureDate).HasComment("Ngày sản xuất");
            entity.Property(e => e.Origin).HasComment("xuất xứ");
        });

        modelBuilder.Entity<LotProductDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOT_PROD__3214EC273F60F572");
        });

        modelBuilder.Entity<MapDataGp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MAP_DATA__3214EC274CED77EE");
        });

        modelBuilder.Entity<MapStockProdIn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MAP_STOC__3214EC278238DB8A");
        });

        modelBuilder.Entity<MappingControllerTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MAPPING___3214EC2784D333C6");
        });

        modelBuilder.Entity<MappingMain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MAPPING___3214EC279AFADF2E");

            entity.Property(e => e.ObjRelative).HasComment("(Chính, Hỗ trợ, Bổ sung, Phụ lục)");
            entity.Property(e => e.ObjRootCode).HasComment("Danh sách tất cả key (Code Y/C đặt hàng, Code Dự án...)");
            entity.Property(e => e.ObjType).HasComment("PROJECT, PO_BUY, PO_SALE, ORDER, REQ_PRICE");
        });

        modelBuilder.Entity<MappingModul>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MAPPING___3214EC278066F7FB");
        });

        modelBuilder.Entity<MaterialAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MATERIAL__3214EC2799279CA2");
        });

        modelBuilder.Entity<MaterialFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MATERIAL__3214EC2775038F7D");
        });

        modelBuilder.Entity<MaterialInvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MATERIAL__3214EC27A74619A9");
        });

        modelBuilder.Entity<MaterialPaymentTicket>(entity =>
        {
            entity.HasKey(e => e.PaymentTickitId).HasName("PK__MATERIAL__545E58DDDB56CC41");
        });

        modelBuilder.Entity<MaterialProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MATERIAL__3214EC271C48007D");

            entity.Property(e => e.PriceCostAirline).HasComment("Giá đại lý đường bay");
            entity.Property(e => e.PriceCostCatelogue).HasComment("Giá đại lý catalogue");
            entity.Property(e => e.PriceCostSea).HasComment("Giá đại lý đường biển");
            entity.Property(e => e.PriceRetailBuild).HasComment("Giá bán lẻ có thi công");
            entity.Property(e => e.PriceRetailBuildAirline).HasComment("Giá bán lẻ có thi công bay");
            entity.Property(e => e.PriceRetailBuildSea).HasComment("Giá bán lẻ có thi công kho,biển");
            entity.Property(e => e.PriceRetailNoBuild).HasComment("Giá bán lẻ không thi công");
            entity.Property(e => e.PriceRetailNoBuildAirline).HasComment("Giá bán lẻ không thi công bay");
            entity.Property(e => e.PriceRetailNoBuildSea).HasComment("Giá bán lẻ không thi công kho, biển");
        });

        modelBuilder.Entity<MaterialProductGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MATERIAL__3214EC27662794FF");
        });

        modelBuilder.Entity<MaterialStore>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("PK__MATERIAL__F5E247F15D94B5B0");
        });

        modelBuilder.Entity<MaterialStoreBatchGood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MATERIAL__3214EC27C36929CC");
        });

        modelBuilder.Entity<MaterialType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MATERIAL__3214EC27A12E7BF7");
        });

        modelBuilder.Entity<MeetingSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__APP_VEND__E99CB38515F0FDBA");
        });

        modelBuilder.Entity<MessageActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MESSAGE___3214EC2775826356");
        });

        modelBuilder.Entity<MobiFunctionJobcardList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MOBI_FUN__3214EC27B8816287");
        });

        modelBuilder.Entity<MobileAppFunction>(entity =>
        {
            entity.HasKey(e => e.AppFunctionId).HasName("PK__MOBILE_A__A5B8F15332EC4AAF");
        });

        modelBuilder.Entity<MobileFunction>(entity =>
        {
            entity.HasKey(e => e.FunctionCode).HasName("PK__MOBILE_F__157D5A598C921F7E");

            entity.Property(e => e.FunctionId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.ParentCodeNavigation).WithMany(p => p.InverseParentCodeNavigation).HasConstraintName("FK__MOBILE_FU__PAREN__1AFEE62D");
        });

        modelBuilder.Entity<MobilePermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PK__MOBILE_P__EB3C611E6F0EB64E");
        });

        modelBuilder.Entity<MobileResource>(entity =>
        {
            entity.HasKey(e => e.ResourceCode).HasName("PK__MOBILE_R__094C9AB2546E0F15");

            entity.Property(e => e.ResourceId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MoiblePrivilege>(entity =>
        {
            entity.Property(e => e.PrivilegeId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotifyId).HasName("PK__NOTIFICA__33BCA7C85929D114");

            entity.Property(e => e.NotifyId).HasComment("Customer Id");
        });

        modelBuilder.Entity<NotificationManager>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NOTIFICA__3214EC278DB81C31");
        });

        modelBuilder.Entity<NotificationObject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NOTIFICA__3214EC2707A7B862");
        });

        modelBuilder.Entity<ObeAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OBE_ACCO__3214EC2746EDFEA2");
        });

        modelBuilder.Entity<ObeAiRecognitionTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OBE_AI_R__3214EC2712964153");
        });

        modelBuilder.Entity<ObeListDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OBE_LIST__3214EC27AD8BCAB9");
        });

        modelBuilder.Entity<ObjectTypeStatusGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OBJECT_T__3214EC27CAFC11A9");
        });

        modelBuilder.Entity<ObjectiverPackCover>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OBJECTIV__3214EC27416FA279");
        });

        modelBuilder.Entity<ObjectiverPackCoverAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OBJECTIV__3214EC2748E61C27");
        });

        modelBuilder.Entity<OperationLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OPERATIO__3214EC27580E262B");
        });

        modelBuilder.Entity<OperationOnlineSupport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OPERATIO__3214EC279970D853");
        });

        modelBuilder.Entity<OperationOnlineSupportTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OPERATIO__3214EC27A48E5C6B");
        });

        modelBuilder.Entity<OrderRequestRaw>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ORDER_RE__3214EC27446FA3D9");
        });

        modelBuilder.Entity<OrderRequestRaw275>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ORDER_RE__3214EC27D71E6670");
        });

        modelBuilder.Entity<OrderRequestRaw288>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ORDER_RE__3214EC27FA3CC503");
        });

        modelBuilder.Entity<OrderRequestRawFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ORDER_RE__3214EC2760B616AC");
        });

        modelBuilder.Entity<OrderRequestRawFiles275>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ORDER_RE__3214EC27AB4D8CF3");
        });

        modelBuilder.Entity<OtpManger>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PAreaCategory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PAreaCategoryStore>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PAreaMapping>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PAreaMappingStore>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PackingType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ATTR_GAL__3214EC277D7F1D30");
        });

        modelBuilder.Entity<Param4Warning>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PARAM_4___3214EC2723914B01");
        });

        modelBuilder.Entity<PayDecisionDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PAY_DECI__3214EC275F0ADB74");
        });

        modelBuilder.Entity<PayDecisionHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PAY_DECI__3214EC277A872C45");
        });

        modelBuilder.Entity<PayScale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PAY_SCAL__3214EC27E2B29D2B");
        });

        modelBuilder.Entity<PayScaleDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PAY_SCAL__3214EC2700B5DDDE");
        });

        modelBuilder.Entity<PaySheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PAY_SHEE__3214EC271A5F97A3");
        });

        modelBuilder.Entity<PaymentGateway>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PinDatum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PlanExcuteRecruitmentDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PLAN_REC__3214EC279B10F4F9");
        });

        modelBuilder.Entity<PlanExcuteRecruitmentHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PLAN_REC__3214EC27D89F2BDF");
        });

        modelBuilder.Entity<PlanRecruitmentDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PLAN_REC__3214EC27A289533F");
        });

        modelBuilder.Entity<PlanRecruitmentHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PLAN_REC__3214EC27E706A5C7");
        });

        modelBuilder.Entity<PluginManage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ZOOM_MAN__3214EC271DE0B89A");
        });

        modelBuilder.Entity<PoBuyerDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PO_SUP_D__3214EC271AEC05C8");
        });

        modelBuilder.Entity<PoBuyerHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PO_SUP_H__3214EC272631A336");

            entity.Property(e => e.Consigner).HasComment("Người gửi hàng");
            entity.Property(e => e.DateOfOrder).HasComment("Date of order");
        });

        modelBuilder.Entity<PoBuyerHeaderNotDone>(entity =>
        {
            entity.ToView("PO_BUYER_HEADER_NOT_DONE");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PoBuyerHeaderPayment>(entity =>
        {
            entity.ToView("PO_BUYER_HEADER_PAYMENT");
        });

        modelBuilder.Entity<PoCusUpdatedTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PO_CUS_U__3214EC27D27372EC");
        });

        modelBuilder.Entity<PoSaleHeader>(entity =>
        {
            entity.HasKey(e => e.ContractHeaderId).HasName("PK__CONTRACT__809C800A0B92E6AD");

            entity.Property(e => e.ContractHeaderId).HasComment("Customer Id");
        });

        modelBuilder.Entity<PoSaleHeaderHi>(entity =>
        {
            entity.HasKey(e => e.ContractHeaderId).HasName("PK__CONTRACT__809C800A8282F706");

            entity.Property(e => e.ContractHeaderId).HasComment("Customer Id");
        });

        modelBuilder.Entity<PoSaleHeaderNotDone>(entity =>
        {
            entity.ToView("PO_SALE_HEADER_NOT_DONE");

            entity.Property(e => e.ContractHeaderId).ValueGeneratedOnAdd();
        });

        //modelBuilder.Entity<PoSaleProductDetail>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__CONTRACT__3214EC27BD919CB6");

        //    entity.Property(e => e.Id).HasComment("Customer Id");
        //    entity.Property(e => e.CustomFee).HasComment("CHIẾT KHẤU");
        //    entity.Property(e => e.Discount).HasComment("GIẢM GIÁ");
        //});

        //modelBuilder.Entity<PoSupAttribute>(entity =>
        //{
        //    entity.HasKey(e => e.ContractAttributeId).HasName("PK__PO_SUP_A__CA96A4ABCB55A108");

        //    entity.Property(e => e.ContractAttributeId).HasComment("Customer Id");
        //});

        modelBuilder.Entity<PoSupFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PO_SUP_F__3214EC27ABF79ACA");
        });

        //modelBuilder.Entity<PoSupRequestImpProduct>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PO_SUP_R__3214EC27FBE241B2");

        //    entity.Property(e => e.PoSupCode).HasComment("Mã Po sup");
        //    entity.Property(e => e.ReqCode).HasComment("Mã yêu cầu nhập khẩu");
        //});

        modelBuilder.Entity<PoSupUpdatedTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PO_SUP_U__3214EC27A94E4A86");
        });

        modelBuilder.Entity<PoolMemberNotification>(entity =>
        {
            entity.HasKey(e => e.NotifyId).HasName("PK__POOL_MEM__33BCA7C83779668F");

            entity.Property(e => e.NotifyId).HasComment("Customer Id");
        });

        //modelBuilder.Entity<ProdDeliveryAttrValue>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROD_DEL__3214EC271BCDF967");
        //});

        //modelBuilder.Entity<ProdDeliveryDetail>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROD_DEL__3214EC27643F390D");

        //    entity.Property(e => e.Id).HasComment("Customer Id");
        //});

        //modelBuilder.Entity<ProdDeliveryHeader>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROD_DEL__3214EC2744BB2340");

        //    entity.Property(e => e.Id).HasComment("Customer Id");
        //});

        //modelBuilder.Entity<ProdInStockAttrValue>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROD_IN___3214EC271F021E32");
        //});

        //modelBuilder.Entity<ProdPackageDelivery>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROD_PAC__3214EC2765E592B1");
        //});

        //modelBuilder.Entity<ProdPackageReceived>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROD_PAC__3214EC278289CB6C");
        //});

        //modelBuilder.Entity<ProdReceivedAttrValue>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROD_REC__3214EC27B87D270C");
        //});

        //modelBuilder.Entity<ProdReceivedDetail>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROD_REC__3214EC27C7F47383");

        //    entity.Property(e => e.Id).HasComment("Customer Id");
        //});

        //modelBuilder.Entity<ProdReceivedHeader>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROD_REC__3214EC27210B21C9");

        //    entity.Property(e => e.Id).HasComment("Customer Id");
        //});

        //modelBuilder.Entity<ProductAttrExt>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<ProductAttrGalaxy>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC27432A73A2");
        //});

        //modelBuilder.Entity<ProductAttribute>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC27647D1205");
        //});

        //modelBuilder.Entity<ProductComponent>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC27B2D951D4");
        //});

        //modelBuilder.Entity<ProductCostDetail>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC272BF11792");

        //    entity.Property(e => e.PriceCostAirline).HasComment("Giá đại lý đường bay");
        //    entity.Property(e => e.PriceCostCatelogue).HasComment("Giá đại lý catalogue");
        //    entity.Property(e => e.PriceCostSea).HasComment("Giá đại lý đường biển");
        //    entity.Property(e => e.PriceRetailBuild).HasComment("Giá bán lẻ có thi công");
        //    entity.Property(e => e.PriceRetailBuildAirline).HasComment("Giá bán lẻ có thi công bay");
        //    entity.Property(e => e.PriceRetailBuildSea).HasComment("Giá bán lẻ có thi công kho,biển");
        //    entity.Property(e => e.PriceRetailNoBuild).HasComment("Giá bán lẻ không thi công");
        //    entity.Property(e => e.PriceRetailNoBuildAirline).HasComment("Giá bán lẻ không thi công bay");
        //    entity.Property(e => e.PriceRetailNoBuildSea).HasComment("Giá bán lẻ không thi công kho, biển");
        //});

        //modelBuilder.Entity<ProductCostHeader>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC27FE526C88");
        //});

        //modelBuilder.Entity<ProductEntityMapping>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC0776309613");
        //});

        //modelBuilder.Entity<ProductEntityMappingLog>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC07D340750F");
        //});

        //modelBuilder.Entity<ProductInStock>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC273323A7B4");

        //    entity.Property(e => e.Id).HasComment("Customer Id");
        //});

        //modelBuilder.Entity<ProductLotFile>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC27F0906E4A");
        //});

        modelBuilder.Entity<ProductPackMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC07A032E0AE");
        });

        //modelBuilder.Entity<ProductQrCode>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC276B62D2AF");

        //    entity.Property(e => e.Type).HasComment("SP hay SP trong kho(lô, phiếu nhập)");
        //});

        //modelBuilder.Entity<ProgressTracking>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROGRESS__3214EC27402F2F1C");
        //});

        //modelBuilder.Entity<Project>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROJECT__3214EC278E0FD498");

        //    entity.Property(e => e.Address).HasComment("Address");
        //});

        //modelBuilder.Entity<ProjectAppointment>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<ProjectAttribute>(entity =>
        //{
        //    entity.HasKey(e => e.AttrCode).HasName("PK__PROJECT___486BFE69858EF298");

        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<ProjectCusSup>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROJECT___3214EC274DF9900E");
        //});

        //modelBuilder.Entity<ProjectFile>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROJECT___3214EC27F24D7493");
        //});

        //modelBuilder.Entity<ProjectMember>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROJECT___3214EC2769519517");
        //});

        //modelBuilder.Entity<ProjectNote>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROJECT___3214EC27850A0CD4");

        //    entity.Property(e => e.Id).HasComment("Customer Id");
        //});

        //modelBuilder.Entity<ProjectProduct>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROJECT___3214EC27CE14AE9F_copy1");

        //    entity.Property(e => e.CustomFee).HasComment("CHIẾT KHẤU");
        //    entity.Property(e => e.Discount).HasComment("GIẢM GIÁ");
        //});

        //modelBuilder.Entity<ProjectProductDetail>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<ProjectProductHeader>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<ProjectService>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROJECT___3214EC27CE14AE9F");
        //});

        //modelBuilder.Entity<ProjectServiceDetail>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<ProjectServiceHeader>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<ProjectSupplier>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROJECT___3214EC2757E61940");
        //});

        //modelBuilder.Entity<ProjectTeam>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROJECT___3214EC2723E1075A");
        //});

        //modelBuilder.Entity<ProjectTeamUser>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__PROJECT___3214EC2796AE7779");
        //});

        //modelBuilder.Entity<QuizPool>(entity =>
        //{
        //    entity.Property(e => e.Id).HasComment("Customer Id");
        //});

        //modelBuilder.Entity<RecordDeliveryDetail>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__RECORD_D__3214EC27EEB5F34B");
        //});

        //modelBuilder.Entity<RecordDeliveryHeader>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__RECORD_D__3214EC274FD02F1C");
        //});

        //modelBuilder.Entity<RecordsPack>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__RECORDS___3214EC2771BA6B66");
        //});

        //modelBuilder.Entity<RecordsPackArrangeLog>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__RECORDS___3214EC27763DFDFD");
        //});

        //modelBuilder.Entity<RecordsPackAttr>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__RECORDS___3214EC27E37571CC");
        //});

        modelBuilder.Entity<RecordsPackFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RECORDS___3214EC274BD7D0B5");
        });

        //modelBuilder.Entity<RecruitmentScheduler>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__RECRUITM__3214EC272912B27A");
        //});

        //modelBuilder.Entity<ReminderAttr>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__REMINDER__3214EC2748CBB671");
        //});

        //modelBuilder.Entity<RequestImpProductDetail>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__REQUEST___3214EC278F6C2946");
        //});

        //modelBuilder.Entity<RequestImpProductHeader>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__REQUEST___3214EC27B511DB27");
        //});

        //modelBuilder.Entity<RequestPoSup>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__REQUEST___3214EC2797E3E4F5");
        //});

        //modelBuilder.Entity<RequestPriceDetail>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__REQUEST___3214EC27E5CCD53E");
        //});

        //modelBuilder.Entity<RequestPriceHeader>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__REQUEST___3214EC2788442BEC");
        //});

        //modelBuilder.Entity<ResultFindOcr>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__RESULT_F__3214EC27EE0F598E");
        //});

        //modelBuilder.Entity<RmCancelTracking>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<RmCommandOrderTruck>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        modelBuilder.Entity<RmCommonSetting>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        //modelBuilder.Entity<RmDriverActivityLog>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<RmECompany>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<RmGisTable>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<RmHrEmployee>(entity =>
        //{
        //    entity.Property(e => e.Accountholder).HasComment("Chủ tài khoản - AccountHolder");
        //    entity.Property(e => e.Accountnumber).HasComment("Số tài khoản - AccountNumber");
        //    entity.Property(e => e.Accountopenplace).HasComment("Nơi mở tài khoản - AccountOpenPlace");
        //    entity.Property(e => e.Bank).HasComment("Ngân hàng - Bank");
        //    entity.Property(e => e.Birthday).HasComment("Ngày sinh - Birthday");
        //    entity.Property(e => e.Birthofplace).HasComment("Nguyên quán - BirthOfPlace");
        //    entity.Property(e => e.Computerskill).HasComment("Trình độ tin học - ComputerSkill");
        //    entity.Property(e => e.Disciplines).HasComment("Ngành học - Disciplines");
        //    entity.Property(e => e.Educationallevel).HasComment("Trình độ văn hóa - EducationalLevel");
        //    entity.Property(e => e.Emailpassword).HasComment("EmailPassword");
        //    entity.Property(e => e.Emailuser).HasComment("EmailUser");
        //    entity.Property(e => e.Employeegroup)
        //        .HasDefaultValueSql("((1))")
        //        .HasComment("1: Nhân viên\r\n2: Giáo viên\r\n3: Gia sư\r\n4: Thực tập - EmployeeGroup");
        //    entity.Property(e => e.Employeekind).HasComment("Loại hình nhân viên - EmployeeKind");
        //    entity.Property(e => e.Employeetype).HasComment("Kiểu nhân viên - EmployeeType");
        //    entity.Property(e => e.Factiondate).HasComment("Ngày vào đảng - FactionDate");
        //    entity.Property(e => e.Fullname).HasComment("Họ vs tên - FullName");
        //    entity.Property(e => e.Gender).HasComment("Giới tính - Gender");
        //    entity.Property(e => e.Health).HasComment("Sức khẻo - Health");
        //    entity.Property(e => e.Id)
        //        .ValueGeneratedOnAdd()
        //        .HasComment("id - Id");
        //    entity.Property(e => e.Identification).HasComment("Nhận dạng - Identification");
        //    entity.Property(e => e.Identitycard).HasComment("Chứng minh nhân dân - IdentityCard");
        //    entity.Property(e => e.Identitycarddate).HasComment("Ngày cấp chứng minh thư - IdentityCardDate");
        //    entity.Property(e => e.Identitycardplace).HasComment("Nới cấp chứng minh thư - IdentityCardPlace");
        //    entity.Property(e => e.Languagelevel).HasComment("Trình độ ngoại ngử - LanguageLevel");
        //    entity.Property(e => e.Maritalstatus).HasComment("Tình trạng hôn nhân - MaritalStatus");
        //    entity.Property(e => e.Nation).HasComment("Dân tộc - Nation");
        //    entity.Property(e => e.Nationlaty).HasComment("Quốc tịch - Nationlaty");
        //    entity.Property(e => e.Nickname).HasComment("Tên thường dùng - NickName");
        //    entity.Property(e => e.Permanentresidence).HasComment("Hộ khẩu thường trú - PermanentResidence");
        //    entity.Property(e => e.Phone).HasComment("Số điện thoại - Phone");
        //    entity.Property(e => e.Picture).HasComment("Id Hình ảnh - Picture");
        //    entity.Property(e => e.Position).HasComment("Chức vụ - Position");
        //    entity.Property(e => e.Religion).HasComment("Tôn giáo - Religion");
        //    entity.Property(e => e.Salaryfactor).HasComment("Hệ số lương - SalaryFactor");
        //    entity.Property(e => e.Salarygroup).HasComment("Nhóm lương - SalaryGroup");
        //    entity.Property(e => e.Salarytype).HasComment("Loại lương - SalaryType");
        //    entity.Property(e => e.Socialinsurance).HasComment("Số bảo hiểm xã hội - SocialInsurance");
        //    entity.Property(e => e.Socialinsurancedate).HasComment("Ngày cấp bảo hiểm xa hội - SocialInsuranceDate");
        //    entity.Property(e => e.Socialinsuranceplace).HasComment("Nơi cấp bảo hiểm xã hội - SocialInsurancePlace");
        //    entity.Property(e => e.Specialized).HasComment("Chuyên ngành - Specialized");
        //    entity.Property(e => e.Status).HasComment("Trạng thái - Status");
        //    entity.Property(e => e.Taxcode).HasComment("Mã số thuế - TaxCode");
        //    entity.Property(e => e.Trainingschool).HasComment("Trường đào tạo - TrainingSchool");
        //    entity.Property(e => e.Trainingtime).HasComment("Thời gian đào tạo - TrainingTime");
        //    entity.Property(e => e.Trainingtype).HasComment(" TrainingType");
        //    entity.Property(e => e.Unit).HasComment("Đơn vị - Unit");
        //    entity.Property(e => e.Wage).HasComment("Bậc lương - Wage");
        //});

        modelBuilder.Entity<RmJnanaApiGoogleService>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        //modelBuilder.Entity<RmJnanaCountRequestGoogle>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__RM_JNANA__3214EC0747506C57");
        //});

        //modelBuilder.Entity<RmJnanaFcm>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__RM_JNANA__3214EC072244E88D");
        //});

        //modelBuilder.Entity<RmJnanaFcmMessage>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__RM_JNANA__3214EC07F2CD7D5D");
        //});

        //modelBuilder.Entity<RmJnanaFile>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<RmJnanaNewsArticle>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<RmJnanaNewsArticleFile>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<RmJnanaNewsCat>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        modelBuilder.Entity<RmRomoocCurrentPosition>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        //modelBuilder.Entity<RmRomoocDriver>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<RmRomoocExtrafield>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        modelBuilder.Entity<RmRomoocFcm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmRomoocFcmMessage>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmRomoocPacking>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmRomoocRemooc>(entity =>
        {
            entity.Property(e => e.Extrafield).HasDefaultValueSql("((10))");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmRomoocTracking>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmRomoocTractor>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        //modelBuilder.Entity<RmSosInfo>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__RM_SOS_I__3214EC2720BA45B4");
        //});

        modelBuilder.Entity<RmSosMedium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RM_SOS_M__3214EC27B8788A65");
        });

        //modelBuilder.Entity<RmVayxeActivityRequestStatusDelivery>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<RmVayxeBookChecking>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        modelBuilder.Entity<RmVayxeBookMaterialDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmVayxeBookServiceDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmVayxeCatSevice>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmVayxeMaterialGood>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<RmVayxeTableCostDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        //modelBuilder.Entity<RmVayxeTableCostHeader>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<RmVayxeVendor>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<SalaryEmployeeMonth>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__SALARY_E__3214EC27CB89047B");
        //});

        //modelBuilder.Entity<SalaryTableAllowance>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__SALARY_T__3214EC2717D91982");
        //});

        modelBuilder.Entity<ServiceCat>(entity =>
        {
            entity.Property(e => e.ServiceCatId)
                .ValueGeneratedOnAdd()
                .HasComment("Customer Id");
        });

        modelBuilder.Entity<ServiceCatAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SERVICE___3214EC27B8EFB10D");
        });

        modelBuilder.Entity<ServiceCatCostCondition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SERVICE___3214EC2763C4410A");
        });

        modelBuilder.Entity<ServiceCatCostHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SERVICE___3214EC278929C386");
        });

        modelBuilder.Entity<ServiceCatGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SERVICE___3214EC2793ACD749");
        });

        modelBuilder.Entity<ServiceCatType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SERVICE___3214EC27E304DE73");
        });

        modelBuilder.Entity<SessionItemChkItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SESSION___3214EC2716744961");
        });

        //modelBuilder.Entity<SessionWork>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__SESSION___3214EC2792324EAA");
        //});

        //modelBuilder.Entity<SessionWorkResult>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WORK_ITE__3214EC2708DE195E");

        //    entity.Property(e => e.EndTime).HasDefaultValueSql("('')");
        //});

        //modelBuilder.Entity<SetCompanyMenu>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__SET_COMP__3214EC27997330BC");
        //});

        modelBuilder.Entity<SetIcon2Object>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SET_ICON__3214EC073949C7BE");
        });

        //modelBuilder.Entity<SettingUserguide>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<ShiftLog>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__SHIFT_LO__3214EC27EC64EC1D");
        //});

        //modelBuilder.Entity<StaffScheduleWork>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__STAFF_SC__3214EC2733AA9790");
        //});

        //modelBuilder.Entity<StatusGroup>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__STATUS_G__3214EC2738ACDE87");
        //});

        modelBuilder.Entity<StatusSetDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STATUS_S__3214EC27A5575935");
        });

        modelBuilder.Entity<StatusSetHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STATUS_S__3214EC2758583D41");
        });

        //modelBuilder.Entity<StockArrangePopEntry>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<StockArrangePutEntry>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<StopContractDetail>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__STOP_CON__3214EC27DAC23731");
        //});

        //modelBuilder.Entity<StopContractHeader>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__STOP_CON__3214EC276B59913B");
        //});

        //modelBuilder.Entity<SubProduct>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__SUB_PROD__3214EC279BEEC8AC");

        //    entity.Property(e => e.PriceCostAirline).HasComment("Giá đại lý đường bay");
        //    entity.Property(e => e.PriceCostCatelogue).HasComment("Giá đại lý catalogue");
        //    entity.Property(e => e.PriceCostSea).HasComment("Giá đại lý đường biển");
        //    entity.Property(e => e.PricePerM).HasComment("Giá /m...");
        //    entity.Property(e => e.PricePerM2).HasComment("Giá / m2");
        //    entity.Property(e => e.PriceRetailBuild).HasComment("Giá bán lẻ có thi công");
        //    entity.Property(e => e.PriceRetailBuildAirline).HasComment("Giá bán lẻ có thi công bay");
        //    entity.Property(e => e.PriceRetailBuildSea).HasComment("Giá bán lẻ có thi công kho,biển");
        //    entity.Property(e => e.PriceRetailNoBuild).HasComment("Giá bán lẻ không thi công");
        //    entity.Property(e => e.PriceRetailNoBuildAirline).HasComment("Giá bán lẻ không thi công bay");
        //    entity.Property(e => e.PriceRetailNoBuildSea).HasComment("Giá bán lẻ không thi công kho, biển");
        //});

        //modelBuilder.Entity<SubWorkflowInstance>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__SUB_WORK__3214EC27F471939E");
        //});

        //modelBuilder.Entity<Supplier>(entity =>
        //{
        //    entity.HasKey(e => e.SupId).HasName("PK__SUPPLIER__F7818086F6AD0905");

        //    entity.Property(e => e.SupId).HasComment("Supplier Id");
        //    entity.Property(e => e.Address).HasComment("Address");
        //    entity.Property(e => e.Description).HasComment("Note");
        //    entity.Property(e => e.Email).HasComment("Email");
        //    entity.Property(e => e.Fax).HasComment("Fax");
        //    entity.Property(e => e.Flag).HasDefaultValueSql("((1))");
        //    entity.Property(e => e.LotName).HasComment("Supplier Type");
        //    entity.Property(e => e.Mobile).HasComment("Mobile");
        //    entity.Property(e => e.Status).HasComment("Status");
        //    entity.Property(e => e.SupCode).HasComment("Supplier Code");
        //    entity.Property(e => e.SupGroup).HasComment("Supplier Group");
        //    entity.Property(e => e.SupName).HasComment("Supplier Name");
        //    entity.Property(e => e.TaxCode).HasComment("Tax Code");
        //    entity.Property(e => e.Telephone).HasComment("Telephone");
        //    entity.Property(e => e.UserId).HasComment("UserId");
        //    entity.Property(e => e.Website).HasComment("Website");
        //});

        //modelBuilder.Entity<SupplierAppointment>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<SupplierExtend>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__SUPPLIER__3213E83FBFAD5718");
        //});

        //modelBuilder.Entity<SupplierFile>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__SUPPLIER__3214EC2706FF767A");
        //});

        //modelBuilder.Entity<Team>(entity =>
        //{
        //    entity.HasKey(e => e.TeamCode).HasName("PK__TEAM__6C619E6ECFE52018");

        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<TempKeyWordSearch>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__TEMP_KEY__3214EC27D08F53C0");
        //});

        //modelBuilder.Entity<TemplateKeySearchFile>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__TEMPLATE__3214EC27B19EC3CB");
        //});

        //modelBuilder.Entity<TokenManager>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__APIGOOGL__3214EC270994BE24");
        //});

        modelBuilder.Entity<TransDeliveryNoteDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TRANS_DE__3214EC27DD12A96D");
        });

        modelBuilder.Entity<TransDeliveryNoteHeader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TRANS_DE__3214EC27283937FE");
        });

        //modelBuilder.Entity<Transition>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__TRANSITI__3214EC2771662C7B");
        //});

        //modelBuilder.Entity<UserAccessDataKeyword>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__USER_ACC__3214EC27A568AAE3");
        //});

        //modelBuilder.Entity<UserDeclareBusyOrFree>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__USER_DEC__3214EC2788935EA0");
        //});

        //modelBuilder.Entity<UserDoExerciseResult>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<UserExaminationResultDetail>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__USER_EXE__3214EC278CB97067");
        //});

        //modelBuilder.Entity<UserExaminationResultSession>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__USER_EXE__3214EC279A0C77C9");
        //});

        //modelBuilder.Entity<UserExerciseResultDetail>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__USER_EXE__3214EC27A1D93EE9");
        //});

        //modelBuilder.Entity<UserExerciseResultSession>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__USER_EXE__3214EC27EC76328C");
        //});

        //modelBuilder.Entity<UserLearnSubject>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        modelBuilder.Entity<UserTrackingGp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__USER_TRA__3214EC27E831BDC9");
        });

        //modelBuilder.Entity<UserWishListSubject>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<UsrKeyWordSetup>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__USR_KEY___3214EC275C4ACB7B");
        //});

        //modelBuilder.Entity<VActionCard>(entity =>
        //{
        //    entity.ToView("V_ACTION_CARD");
        //});

        //modelBuilder.Entity<VAllObject>(entity =>
        //{
        //    entity.ToView("V_ALL_OBJECT");
        //});

        modelBuilder.Entity<VAllTable>(entity =>
        {
            entity.ToView("V_ALL_TABLE");
        });

        modelBuilder.Entity<VAmchartAsset>(entity =>
        {
            entity.ToView("V_AMCHART_ASSET");
        });

        modelBuilder.Entity<VAmchartBuy>(entity =>
        {
            entity.ToView("V_AMCHART_BUY");
        });

        modelBuilder.Entity<VAmchartCardWork>(entity =>
        {
            entity.ToView("V_AMCHART_CARD_WORK");
        });

        modelBuilder.Entity<VAmchartCountBuy>(entity =>
        {
            entity.ToView("V_AMCHART_COUNT_BUY");
        });

        modelBuilder.Entity<VAmchartCountCustomer>(entity =>
        {
            entity.ToView("V_AMCHART_COUNT_CUSTOMER");
        });

        modelBuilder.Entity<VAmchartCountEmployee>(entity =>
        {
            entity.ToView("V_AMCHART_COUNT_EMPLOYEE");
        });

        modelBuilder.Entity<VAmchartCountProject>(entity =>
        {
            entity.ToView("V_AMCHART_COUNT_PROJECT");
        });

        modelBuilder.Entity<VAmchartCountSale>(entity =>
        {
            entity.ToView("V_AMCHART_COUNT_SALE");
        });

        modelBuilder.Entity<VAmchartCountSupplier>(entity =>
        {
            entity.ToView("V_AMCHART_COUNT_SUPPLIER");
        });

        modelBuilder.Entity<VAmchartCrawlingLog>(entity =>
        {
            entity.ToView("V_AMCHART_CRAWLING_LOG");
        });

        modelBuilder.Entity<VAmchartCustomer>(entity =>
        {
            entity.ToView("V_AMCHART_CUSTOMER");
        });

        modelBuilder.Entity<VAmchartDoExercise>(entity =>
        {
            entity.ToView("V_AMCHART_DO_EXERCISE");
        });

        modelBuilder.Entity<VAmchartLearnSubject>(entity =>
        {
            entity.ToView("V_AMCHART_LEARN_SUBJECT");
        });

        modelBuilder.Entity<VAmchartPieBuy>(entity =>
        {
            entity.ToView("V_AMCHART_PIE_BUY");
        });

        modelBuilder.Entity<VAmchartPieCustomer>(entity =>
        {
            entity.ToView("V_AMCHART_PIE_CUSTOMER");
        });

        modelBuilder.Entity<VAmchartPieProject>(entity =>
        {
            entity.ToView("V_AMCHART_PIE_PROJECT");
        });

        modelBuilder.Entity<VAmchartPieSale>(entity =>
        {
            entity.ToView("V_AMCHART_PIE_SALE");
        });

        modelBuilder.Entity<VAmchartPieSupplier>(entity =>
        {
            entity.ToView("V_AMCHART_PIE_SUPPLIER");
        });

        modelBuilder.Entity<VAmchartProject>(entity =>
        {
            entity.ToView("V_AMCHART_PROJECT");
        });

        modelBuilder.Entity<VAmchartSale>(entity =>
        {
            entity.ToView("V_AMCHART_SALE");
        });

        modelBuilder.Entity<VAmchartSupplier>(entity =>
        {
            entity.ToView("V_AMCHART_SUPPLIER");
        });

        modelBuilder.Entity<VAmchartWorkflow>(entity =>
        {
            entity.ToView("V_AMCHART_WORKFLOW");
        });

        modelBuilder.Entity<VAssetStatus>(entity =>
        {
            entity.ToView("V_ASSET_STATUS");
        });

        modelBuilder.Entity<VCardProcess>(entity =>
        {
            entity.ToView("V_CARD_PROCESS");
        });

        modelBuilder.Entity<VCommonSetting>(entity =>
        {
            entity.ToView("V_COMMON_SETTING");

            entity.Property(e => e.SettingId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VHighchartFund>(entity =>
        {
            entity.ToView("V_HIGHCHART_FUND");
        });

        modelBuilder.Entity<VHighchartProd>(entity =>
        {
            entity.ToView("V_HIGHCHART_PROD");
        });

        modelBuilder.Entity<VHisExpProduct>(entity =>
        {
            entity.ToView("V_HIS_EXP_PRODUCT");
        });

        modelBuilder.Entity<VHisImpProduct>(entity =>
        {
            entity.ToView("V_HIS_IMP_PRODUCT");
        });

        modelBuilder.Entity<VHisProduct>(entity =>
        {
            entity.ToView("V_HIS_PRODUCT");
        });

        modelBuilder.Entity<VHrContract>(entity =>
        {
            entity.ToView("V_HR_CONTRACT");
        });

        modelBuilder.Entity<VHrEmployee>(entity =>
        {
            entity.ToView("V_HR_EMPLOYEE");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VImpExpProduct>(entity =>
        {
            entity.ToView("V_IMP_EXP_PRODUCT");
        });

        modelBuilder.Entity<VListBoard>(entity =>
        {
            entity.ToView("V_LIST_BOARD");
        });

        modelBuilder.Entity<VListWeight>(entity =>
        {
            entity.ToView("V_LIST_WEIGHT");
        });

        modelBuilder.Entity<VProductAllTable>(entity =>
        {
            entity.ToView("V_PRODUCT_ALL_TABLE");
        });

        modelBuilder.Entity<VProjectProductRemain>(entity =>
        {
            entity.ToView("V_PROJECT_PRODUCT_REMAIN");
        });

        modelBuilder.Entity<VQuantityInStockByStore>(entity =>
        {
            entity.ToView("V_QUANTITY_IN_STOCK_BY_STORE");
        });

        modelBuilder.Entity<VReportStaticsPoCu>(entity =>
        {
            entity.ToView("V_REPORT_STATICS_PO_CUS");
        });

        modelBuilder.Entity<VReportStaticsPoSup>(entity =>
        {
            entity.ToView("V_REPORT_STATICS_PO_SUP");
        });

        modelBuilder.Entity<VSubjectHierachy>(entity =>
        {
            entity.ToView("V_SUBJECT_HIERACHY");
        });

        modelBuilder.Entity<VTutorSession>(entity =>
        {
            entity.ToView("V_TUTOR_SESSION");
        });

        modelBuilder.Entity<VcAppAccessLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_APP_A__3214EC27607D4316");
        });

        modelBuilder.Entity<VcCustomerCare>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_CUSTO__3214EC272047AA33");
        });

        modelBuilder.Entity<VcCustomerCareLastMonth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_CUSTO__3214EC2750759135");
        });

        modelBuilder.Entity<VcCustomerDeclareHeaderInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_CUSTO__3214EC272CC8CCBB");
        });

        modelBuilder.Entity<VcCustomerDeclareInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_CUSTO__3214EC27C19709C3");
        });

        modelBuilder.Entity<VcDriver>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VcFcm>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VcFcmMessage>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VcGisTable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VcJnanaFcm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_JNANA__3214EC27C204E6FA");
        });

        modelBuilder.Entity<VcJnanaFcmMessage>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VcJnanaFile>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VcJnanaNewsArticle>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VcJnanaNewsArticleFile>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VcJnanaNewsCat>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VcLeaderApprove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_LEADE__3214EC270CEFEB29");
        });

        modelBuilder.Entity<VcProductCat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_PRODU__3214EC27DAD4E0A1");

            entity.Property(e => e.Id).HasComment("Customer Id");
        });

        modelBuilder.Entity<VcSettingRoute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_SETTI__3214EC277BB5B9D3");
        });

        modelBuilder.Entity<VcSosInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_SOS_I__3214EC27ACC4A9E0");
        });

        modelBuilder.Entity<VcSosMedium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_SOS_M__3214EC27169689F2");
        });

        modelBuilder.Entity<VcStoreIdea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_STORE__3214EC2704487E21");
        });

        modelBuilder.Entity<VcSupplierTradeRelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_SUPPL__3214EC270334B277");
        });

        modelBuilder.Entity<VcTransporter>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VcWorkCheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_WORK___3214EC274057DF53");
        });

        modelBuilder.Entity<VcWorkPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_WORK___3214EC276A0D5AA8");
        });

        modelBuilder.Entity<VcWorkPlanLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VC_WORK___3214EC2701C58A02");
        });

        modelBuilder.Entity<VocaCertificateCat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VOCA_CER__3214EC271AA6125C");
        });

        modelBuilder.Entity<WalletCoinExchange>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        //modelBuilder.Entity<WalletCoinTransaction>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<WalletDepositTransaction>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<WalletPackage>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<WalletTableCostItem>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<WarehouseRecordsPack>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ASSET_RE__3214EC2758D5099D");
        //});

        //modelBuilder.Entity<WarehouseRecordsPackAttr>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ASSET_RE__3214EC27720870D6");
        //});

        //modelBuilder.Entity<WarehouseRecordsPackFile>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ASSET_RE__3214EC27140E5EBB");
        //});

        //modelBuilder.Entity<WarehouseZoneAttr>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ASSET_ZO__3214EC27A57D8657");
        //});

        //modelBuilder.Entity<WarehouseZoneMapping>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ASSET_ZO__3214EC27E4F049C9");
        //});

        //modelBuilder.Entity<WarehouseZoneStruct>(entity =>
        //{
        //    entity.HasKey(e => e.ZoneCode).HasName("PK__ASSET_ZO__DA72D96078370D31");

        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        //modelBuilder.Entity<WeekWorkingScheduler>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WEEK_WOR__3214EC274771026F");
        //});

        modelBuilder.Entity<WfActivityObjectProcessing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WF_ACTIV__3214EC279F34FEBA");
        });

        //modelBuilder.Entity<WfObject>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WF_OBJEC__3214EC27A6BDEE6F");
        //});

        //modelBuilder.Entity<WfSharpLibrary>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WF_SHARP__3214EC27E2C1A319");
        //});

        modelBuilder.Entity<WhsZoneAttr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WHS_ZONE__DA72D960E4D0EC5B");
        });

        modelBuilder.Entity<WhsZoneStruct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__APP_VEND__E99CB38506F3084D");
        });

        //modelBuilder.Entity<WorkEventCat>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WORK_EVE__3214EC2789FF83D2");
        //});

        modelBuilder.Entity<WorkExecutiveObjectrelative>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WORK_EXE__3214EC2742D436F6");
        });

        //modelBuilder.Entity<WorkFlow>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WORK_FLO__3214EC2744FFFE06");
        //});

        //modelBuilder.Entity<WorkFlowRule>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WORK_FLO__3214EC27CDBB3677");
        //});

        //modelBuilder.Entity<WorkItemAssignStaff>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__JOB_CARD__3214EC2786CFD741");
        //});

        //modelBuilder.Entity<WorkItemSession>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__STAFF_IT__3214EC27D332D876");
        //});

        modelBuilder.Entity<WorkItemSessionResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WORK_ITE__3214EC27346D7613");

            entity.Property(e => e.EndTime).HasDefaultValueSql("('')");
        });

        //modelBuilder.Entity<WorkOsAddressCard>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WORK_OS___3214EC27309095CC");
        //});

        //modelBuilder.Entity<WorkOsBoard>(entity =>
        //{
        //    entity.HasKey(e => e.BoardId).HasName("PK__WORK_OS___10DF125680FAE8D2");
        //});

        modelBuilder.Entity<WorkOsBoardTrackingProgress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WORK_OS___3214EC271F61E7C2");
        });

        //modelBuilder.Entity<WorkOsCard>(entity =>
        //{
        //    entity.HasKey(e => e.CardCode).HasName("PK__WORK_OS___CF0FBF267755B57F");

        //    entity.Property(e => e.CardId).ValueGeneratedOnAdd();
        //});

        modelBuilder.Entity<WorkOsCardTrackingProgress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WORK_OS___3214EC2744C0F8B2");
        });

        //modelBuilder.Entity<WorkOsList>(entity =>
        //{
        //    entity.HasKey(e => e.ListCode).HasName("PK__WORK_OS___1FC670EADDB7EEE1");

        //    entity.Property(e => e.ListId).ValueGeneratedOnAdd();
        //    entity.Property(e => e.Status).HasComment("0: Khởi tạo - 1: Hoạt động - 2: Chậm trế");
        //});

        modelBuilder.Entity<WorkOsListTrackingProgress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WORK_OS___3214EC27FB57D744");
        });

        //modelBuilder.Entity<WorkShiftCheckinOut>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__STAFF_TI__3214EC27B8977AE7");
        //});

        //modelBuilder.Entity<WorkUserEvent>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WORK_USE__3214EC274BD0FE8E");
        //});

        //modelBuilder.Entity<WorkflowActivity>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WORKFLOW__3214EC27425D96D3");
        //});

        //modelBuilder.Entity<WorkflowActivityRole>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WORKFLOW__3214EC277BC78783");
        //});

        //modelBuilder.Entity<WorkflowInstance>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WORKFLOW__3214EC275CFD6443");
        //});

        //modelBuilder.Entity<WorkflowInstanceRunning>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WORKFLOW__3214EC2731AAEC6C");
        //});

        //modelBuilder.Entity<WorkflowMilestone>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WORKFLOW__3214EC27576A6075");
        //});

        //modelBuilder.Entity<WorkflowSetting>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WORKFLOW__3214EC271C5223CE");
        //});

        //modelBuilder.Entity<WorkingSchedule>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__WORKING___3214EC279164EB5C");
        //});

        //modelBuilder.Entity<ZoneDevicePlacement>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ZONE_DEV__3214EC2715834CC8");
        //});

        //modelBuilder.Entity<ZoneSetup>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ZONE_SET__3214EC273BAA8F04");
        //});

        //modelBuilder.Entity<ZoomManage>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__ZOOM_MAN__3214EC27EB135CDF");
        //});

        //modelBuilder.Entity<ZoomReportError>(entity =>
        //{
        //    entity.Property(e => e.Id).ValueGeneratedOnAdd();
        //});

        modelBuilder.Entity<_1ProductEntityMappingLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__1.PRODUC__3214EC0721BB5F0B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
