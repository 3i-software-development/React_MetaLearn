// ======================================
// Author: Ebenezer Monney
// Copyright (c) 2023 www.ebenmonney.com
// 
// ==> Gun4Hire: contact@ebenmonney.com
// ======================================

using DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using DAL.Models.Interfaces;
using ESEIM.Models;

namespace DAL
{

    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        /// Pin Data
        public virtual DbSet<PinData> PinDatas { get; set; }
        /// <summary>
        /// Define Status Group
        /// </summary>
        ///
        public virtual DbSet<StatusGroup> StatusGroups { get; set; }
        public virtual DbSet<ObjectTypeStatusGroup> ObjectTypeStatusGroups { get; set; }


        /// <summary>
        /// Define employee new design
        /// </summary>
        ///
        /// 
        public virtual DbSet<EdmsDynamic> EDMSDynamics { get; set; }
        public virtual DbSet<EdmsDynamicData> EDMSDynamicDatas { get; set; }
        public virtual DbSet<LMSSubject> LMSSubjects { get; set; }
        public virtual DbSet<LmsCourse> LmsCourses { get; set; }
        public virtual DbSet<LmsClass> LmsClasses { get; set; }
        public virtual DbSet<LmsUserClass> LmsUserClasses { get; set; }
        public virtual DbSet<LmsPracticeTestHeader> LmsPracticeTestHeaders { get; set; }
        public virtual DbSet<LmsPracticeTestDetail> LmsPracticeTestDetails { get; set; }
        public virtual DbSet<LmsLectureManagement> LmsLectureManagements { get; set; }
        public virtual DbSet<LmsLectureSubjectCourse> LmsLectureSubjectCourses { get; set; }
        public virtual DbSet<LmsQuizLectureSubjectCourse> LmsQuizLectureSubjectCourses { get; set; }
        public virtual DbSet<LmsSubjectManagement> LmsSubjectManagements { get; set; }
        public virtual DbSet<VSubjectHierachy> VSubjectHieriachies { get; set; }
        public virtual DbSet<LmsTrackDiligence> LmsTrackDiligences { get; set; }
        public virtual DbSet<UserDoExerciseResult> UserDoExerciseResults { get; set; }
        public virtual DbSet<UserLearnSubject> UserLearnSubjects { get; set; }
        public virtual DbSet<UserWishListSubject> UserWishListSubjects { get; set; }
        public virtual DbSet<LmsBoardTask> LmsBoardTasks { get; set; }
        public virtual DbSet<LmsListTask> LmsListTasks { get; set; }
        public virtual DbSet<LmsExamSchedule> LmsExamSchedules { get; set; }
        public virtual DbSet<LmsExamHeader> LmsExamHeaders { get; set; }
        public virtual DbSet<LmsExamDetail> LmsExamDetails { get; set; }
        public virtual DbSet<LmsTutoringSchedule> LmsTutoringSchedules { get; set; }
        public virtual DbSet<VTutorSession> VTutorSessions { get; set; }
        public virtual DbSet<LmsTaskUserItemProgress> LmsTaskUserItemProgresses { get; set; }
        public virtual DbSet<LmsTask> LmsTasks { get; set; }
        public virtual DbSet<LmsTaskStudentAssign> LmsTaskStudentAssigns { get; set; }
        public virtual DbSet<LmsMentorMentee> LmsMentorMentees { get; set; }
        public virtual DbSet<LmsMessageNotification> LmsMessageNotifications { get; set; }
        public virtual DbSet<LmsUserMessage> LmsUserMessages { get; set; }
        public virtual DbSet<LmsQuizPoolReference> LmsQuizPoolReferences { get; set; }
        public virtual DbSet<PayScale> PayScales { get; set; }
        public virtual DbSet<CategoryCareer> CategoryCareers { get; set; }
        public virtual DbSet<PayScaleDetail> PayScaleDetails { get; set; }
        public virtual DbSet<CareerCatScale> CareerCatScales { get; set; }
        public virtual DbSet<PayDecisionHeader> PayDecisionHeaders { get; set; }
        public virtual DbSet<PayDecisionDetail> PayDecisionDetails { get; set; }
        public virtual DbSet<StopContractHeader> StopContractHeaders { get; set; }
        public virtual DbSet<StopContractDetail> StopContractDetails { get; set; }
        public virtual DbSet<EmployeeStatusTracking> EmployeeStatusTrackings { get; set; }
        public virtual DbSet<HrEmployeeDecision> HrEmployeeDecisions { get; set; }
        public virtual DbSet<HREmployeeMobilization> HREmployeeMobilizations { get; set; }
        public virtual DbSet<DecisionMovementHeader> DecisionMovementHeaders { get; set; }
        public virtual DbSet<DecisionMovementDetail> DecisionMovementDetails { get; set; }
        public virtual DbSet<DecisionBonusDisciplineHeader> DecisionBonusDisciplineHeaders { get; set; }
        public virtual DbSet<DecisionBonusDisciplineDetail> DecisionBonusDisciplineDetails { get; set; }
        public virtual DbSet<EmployeeCert> EmployeeCerts { get; set; }
        public virtual DbSet<VocaCertCat> VocaCertCats { get; set; }
        public virtual DbSet<PlanRecruitmentHeader> PlanRecruitmentHeaders { get; set; }
        public virtual DbSet<PlanRecruitmentDetail> PlanRecruitmentDetails { get; set; }
        public virtual DbSet<CriteriaRecruitmentCat> CriteriaRecruitmentCats { get; set; }
        public virtual DbSet<CriteriaRecruimentAttrData> CriteriaRecruimentAttrDatas { get; set; }
        public virtual DbSet<PlanExcuteRecruitmentHeader> PlanExcuteRecruitmentHeaders { get; set; }
        public virtual DbSet<PlanExcuteRecruitmentDetail> PlanExcuteRecruitmentDetails { get; set; }
        public virtual DbSet<FileRecruitment> FileRecruitments { get; set; }
        public virtual DbSet<TemplateKeySearchFile> TemplateKeySearchFiles { get; set; }
        public virtual DbSet<UserAccessDataKeyword> UserAccessDataKeywords { get; set; }

        /// <summary>
        /// Define view for chart dashboard
        /// </summary>
        ///
        public virtual DbSet<VAmchartCrawlingLog> VAmchartCrawlingLog { get; set; }
        public virtual DbSet<VAmchartCardWork> VAmchartCardWorks { get; set; }
        public virtual DbSet<VAmchartCustomer> VAmchartCustomers { get; set; }
        public virtual DbSet<VAmchartSupplier> VAmchartSuppliers { get; set; }
        public virtual DbSet<VAmchartProject> VAmchartProjects { get; set; }
        public virtual DbSet<VAmchartBuy> VAmchartBuys { get; set; }
        public virtual DbSet<VAmchartSale> VAmchartSales { get; set; }
        public virtual DbSet<VAmchartDoExercise> VAmchartDoExercises { get; set; }
        public virtual DbSet<VAmchartLearnSubject> VAmchartLearnSubjects { get; set; }
        public virtual DbSet<VAmchartWorkflows> VAmchartWorkflowss { get; set; }
        public virtual DbSet<VAmchartAsset> VAmchartAssets { get; set; }
        public virtual DbSet<VActionCard> VActionCards { get; set; }
        public virtual DbSet<VCountCardWork> VCountCardWorks { get; set; }

        public virtual DbSet<CandidateCvStorage> CandidateCvStorages { get; set; }
        /// <summary>
        /// WorkFlow
        /// </summary>
        ///
        public virtual DbSet<Activity> Activitys { get; set; }
        public virtual DbSet<WorkflowMilestone> WorkflowMilestones { get; set; }
        public virtual DbSet<WorkflowSetting> WorkflowSettings { get; set; }
        public virtual DbSet<WorkflowInstance> WorkflowInstances { get; set; }
        public virtual DbSet<ActivityInstance> ActivityInstances { get; set; }
        public virtual DbSet<WorkflowInstanceRunning> WorkflowInstanceRunnings { get; set; }
        public virtual DbSet<ActivityInstanceObjective> ActivityInstanceObjectives { get; set; }
        public virtual DbSet<ActivityInstFile> ActivityInstFiles { get; set; }
        public virtual DbSet<ActivityFile> ActivityFiles { get; set; }
        public virtual DbSet<ExcuterControlRole> ExcuterControlRoles { get; set; }
        public virtual DbSet<ExcuterControlRoleInst> ExcuterControlRoleInsts { get; set; }
        public virtual DbSet<ActivityTransition> ActivityTransition { get; set; }
        public virtual DbSet<Transition> Transitions { get; set; }
        public virtual DbSet<WfActivityObjectProccessing> WfActivityObjectProccessings { get; set; }
        public virtual DbSet<JobcardDataLogger> JobcardDataLoggers { get; set; }
        public virtual DbSet<FormBiulderCat> FormBiulderCats { get; set; }
        public virtual DbSet<FormControl> FormControls { get; set; }
        public virtual DbSet<WFSharpLibrary> WFSharpLibrarys { get; set; }
        public virtual DbSet<FileVersion> FileVersions { get; set; }
        public virtual DbSet<ActInstanceUserActivity> ActInstanceUserActivitys { get; set; }
        public virtual DbSet<MessageActivity> MessageActivitys { get; set; }
        public virtual DbSet<SubWorkflowInstance> SubWorkflowInstances { get; set; }

        /// <summary>
        /// Amin System management
        /// </summary>
        public virtual DbSet<AdDivision> AdDivisions { get; set; }
        public virtual DbSet<AdAccessLog> AdAccessLogs { get; set; }
        public virtual DbSet<AdActionLog> AdActionLogs { get; set; }
        public virtual DbSet<AdAppFunction> AdAppFunctions { get; set; }
        public virtual DbSet<MobileAppFunction> MobileAppFunctions { get; set; }
        public virtual DbSet<AdApplication> AdApplications { get; set; }
        public virtual DbSet<AdFunction> AdFunctions { get; set; }
        public virtual DbSet<MobileFunction> MobileFunctions { get; set; }
        public virtual DbSet<AdGroupUser> AdGroupUsers { get; set; }
        public virtual DbSet<AdDepartment> AdDepartments { get; set; }
        public virtual DbSet<AdLanguage> AdLanguages { get; set; }
        public virtual DbSet<AdLanguageText> AdLanguageTexts { get; set; }
        public virtual DbSet<AdOrganization> AdOrganizations { get; set; }
        public virtual DbSet<AdParameter> AdParameters { get; set; }
        public virtual DbSet<AdPermission> AdPermissions { get; set; }
        public virtual DbSet<MobilePermission> MobilePermissions { get; set; }
        public virtual DbSet<AdPrivilege> AdPrivileges { get; set; }
        public virtual DbSet<MobilePrivilege> MobilePrivileges { get; set; }
        public virtual DbSet<AdResource> AdResources { get; set; }
        public virtual DbSet<MobileResource> MobileResources { get; set; }
        public virtual DbSet<AdUserInGroup> AdUserInGroups { get; set; }
        public virtual DbSet<AdUserDepartment> AdUserDepartments { get; set; }
        public virtual DbSet<AdAuthoring> AdAuthorings { get; set; }
        public virtual DbSet<FcmToken> FcmTokens { get; set; }
        /// <summary>
        /// Customer
        /// </summary>
        public virtual DbSet<Customers> Customerss { get; set; }
        public virtual DbSet<CustomerFile> CustomerFiles { get; set; }
        public virtual DbSet<CustomerExtend> CustomerExtends { get; set; }
        public virtual DbSet<CustomerReminder> CustomerReminders { get; set; }
        public virtual DbSet<CustomerAppointment> CustomerAppointments { get; set; }
        public virtual DbSet<OrderRequestRaw> OrderRequestRaws { get; set; }
        public virtual DbSet<OrderRequestRawFiles> OrderRequestRawFiless { get; set; }

        /// <summary>
        /// Supplier
        /// </summary>
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierExtend> SupplierExtends { get; set; }
        public virtual DbSet<SupplierFile> SupplierFiles { get; set; }
        public virtual DbSet<SupplierAppointment> SupplierAppointments { get; set; }

        /// <summary>
        ///EDMS
        /// </summary>
        public virtual DbSet<EDMSCategory> EDMSCategorys { get; set; }
        public virtual DbSet<EDMSRepository> EDMSRepositorys { get; set; }
        public virtual DbSet<EDMSCatRepoSetting> EDMSCatRepoSettings { get; set; }
        public virtual DbSet<EDMSRepoCatFile> EDMSRepoCatFiles { get; set; }
        public virtual DbSet<EDMSFile> EDMSFiles { get; set; }
        public virtual DbSet<EDMSFilePermission> EDMSFilePermissions { get; set; }
        public virtual DbSet<EDMSWareHouse> EDMSWareHouses { get; set; }
        public virtual DbSet<EDMSWareHouseUsers> EDMSWareHouseUsers { get; set; }
        public virtual DbSet<EDMSWhsMedia> EDMSWhsMedias { get; set; }
        public virtual DbSet<EDMSWareHouseMedia> EDMSWareHouseMedias { get; set; }
        public virtual DbSet<EDMSFloor> EDMSFloors { get; set; }
        public virtual DbSet<EDMSLine> EDMSLines { get; set; }
        public virtual DbSet<EDMSRack> EDMSRacks { get; set; }
        public virtual DbSet<EDMSBox> EDMSBoxs { get; set; }
        public virtual DbSet<EDMSBoxFile> EDMSBoxFiles { get; set; }
        public virtual DbSet<EDMSBoxTracking> EDMSBoxTrackings { get; set; }
        public virtual DbSet<EDMSEntityMapping> EDMSEntityMappings { get; set; }
        public virtual DbSet<EDMSMoveBoxLog> EDMSMoveBoxLogs { get; set; }
        public virtual DbSet<EDMSWhsQrCode> EDMSWhsQrCodes { get; set; }
        public virtual DbSet<EDMSRequestInputStore> EDMSRequestInputStores { get; set; }
        public virtual DbSet<EDMSRequestEndBox> EDMSRequestEndBoxs { get; set; }
        public virtual DbSet<EDMSReqInputFile> EDMSReqFiles { get; set; }
        public virtual DbSet<EDMSReqExportFile> EDMSReqExportFiles { get; set; }
        public virtual DbSet<EDMSReceiptInputStore> EDMSReceiptInputStores { get; set; }
        public virtual DbSet<EDMSReceiptExportStore> EDMSReceiptExportStores { get; set; }
        public virtual DbSet<EDMSRecInputFile> EDMSRecFiles { get; set; }
        public virtual DbSet<EDMSRecExportFile> EDMSRecExportFiles { get; set; }
        public virtual DbSet<EDMSTermite> EDMSTermites { get; set; }
        public virtual DbSet<EDMSTermiteBox> EDMSTermiteBoxs { get; set; }
        public virtual DbSet<EDMSRemove> EDMSRemoves { get; set; }
        public virtual DbSet<EDMSRemoveBox> EDMSRemoveBoxs { get; set; }
        public virtual DbSet<EDMSTimeOfDocumentPreservation> EDMSTimeOfDocumentPreservations { get; set; }
        public virtual DbSet<EDMSRequestTracking> EDMSRequestTrackings { get; set; }
        public virtual DbSet<EDMSRequestExportStore> EDMSRequestExportStores { get; set; }
        public virtual DbSet<EDMSWarehouseExtend> EDMSWarehouseExtends { get; set; }
        public virtual DbSet<WORKOSAddressCard> WORKOSAddressCards { get; set; }
        public virtual DbSet<JobCardAssignee> JobCardAssignees { get; set; }
        public virtual DbSet<FilesShareObjectUser> FilesShareObjectUsers { get; set; }
        public virtual DbSet<ObjectiverPackCover> ObjectiverPackCovers { get; set; }
        public virtual DbSet<EDMSFilePackCover> EDMSFilePackCovers { get; set; }
        public virtual DbSet<EDMSEntityMappingDocument> EDMSEntityMappingDocuments { get; set; }
        public virtual DbSet<EDMSMoveBoxLogDocument> EDMSMoveBoxLogDocuments { get; set; }
        public virtual DbSet<EDMSWhsQrCodeDocument> EDMSWhsQrCodeDocuments { get; set; }
        public virtual DbSet<EDMSRepoDefaultObject> EDMSRepoDefaultObjects { get; set; }
        public virtual DbSet<EDMSAudioBook> EdmsAudioBooks { get; set; }
        /// <summary>
        /// EDMS Document
        /// </summary>
        public virtual DbSet<EDMSWareHouseDocument> EDMSWareHouseDocuments { get; set; }
        public virtual DbSet<EDMSFloorDocument> EDMSFloorDocuments { get; set; }
        public virtual DbSet<EDMSLineDocument> EDMSLineDocuments { get; set; }
        public virtual DbSet<EDMSRackDocument> EDMSRackDocuments { get; set; }

        /// <summary>
        /// EDMS Asset
        /// </summary>
        public virtual DbSet<EDMSWareHouseAsset> EDMSWareHouseAssets { get; set; }
        public virtual DbSet<EDMSFloorAsset> EDMSFloorAssets { get; set; }
        public virtual DbSet<EDMSLineAsset> EDMSLineAssets { get; set; }
        public virtual DbSet<EDMSRackAsset> EDMSRackAssets { get; set; }
        public virtual DbSet<EDMSEntityMappingAsset> EDMSEntityMappingAssets { get; set; }
        public virtual DbSet<EDMSWhsQrCodeAsset> EDMSWhsQrCodeAssets { get; set; }
        public virtual DbSet<EDMSFilePackCoverAsset> EDMSFilePackCoverAssets { get; set; }
        public virtual DbSet<ObjectiverPackCoverAsset> ObjectiverPackCoverAssets { get; set; }
        public virtual DbSet<AssetEntityMapping> AssetEntityMappings { get; set; }

        /// <summary>
        /// Service
        /// </summary>
        public virtual DbSet<ServiceCategory> ServiceCategorys { get; set; }
        public virtual DbSet<ContractServiceDetail> ContractServiceDetails { get; set; }
        public virtual DbSet<ContractServiceDetailHis> ContractServiceDetailHiss { get; set; }
        //public virtual DbSet<ProductCat> ProductCats { get; set; }

        /// <summary>
        /// Notification
        /// </summary>
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationManager> NotificationManagers { get; set; }
        public virtual DbSet<NotificationObject> NotificationObjects { get; set; }


        /// <summary>
        /// Tracking
        /// </summary>
        public virtual DbSet<UserTrackingGps> UserTrackingGpss { get; set; }
        /// <summary>
        /// Reminder
        /// </summary>
        public virtual DbSet<ReminderAttr> ReminderAttrs { get; set; }

        /// <summary>
        /// Map
        /// </summary>
        public virtual DbSet<MapDataGps> MapDataGpss { get; set; }

        /// <summary>
        /// Contract
        /// </summary>
        public virtual DbSet<PoSaleHeader> PoSaleHeaders { get; set; }
        public virtual DbSet<PoSaleHeaderHis> PoSaleHeaderHiss { get; set; }
        public virtual DbSet<PoSaleHeaderNotDone> PoSaleHeaderNotDones { get; set; }
        public virtual DbSet<ContractDetail> ContractDetails { get; set; }
        public virtual DbSet<ContractFile> ContractFiles { get; set; }
        public virtual DbSet<ContractPeopleTag> ContractPeopleTags { get; set; }
        public virtual DbSet<ContractAttribute> ContractAttributes { get; set; }
        public virtual DbSet<ContractAttributeHis> ContractAttributeHiss { get; set; }
        public virtual DbSet<ContractActivity> ContractActivitys { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactNote> ContactNotes { get; set; }
        public virtual DbSet<ContractMemberTag> ContractMemberTags { get; set; }
        public virtual DbSet<EntityMapping> EntityMappings { get; set; }
        public virtual DbSet<MappingMain> MappingMains { get; set; }
        public virtual DbSet<PoSupAttribute> PoSupAttributes { get; set; }
        public virtual DbSet<ContractSchedulePay> ContractSchedulePays { get; set; }
        public virtual DbSet<ContractSchedulePayHis> ContractSchedulePayHiss { get; set; }
        public virtual DbSet<VHisImpProduct> VHisImpProducts { get; set; }
        public virtual DbSet<VHisProduct> VHisProducts { get; set; }
        public virtual DbSet<VImpExpProduct> VImpExpProducts { get; set; }
        public virtual DbSet<VReportStaticsPoSup> VReportStaticsPoSups { get; set; }
        public virtual DbSet<VProductAllTable> VProductAllTables { get; set; }
        public virtual DbSet<AssignMemberToOject> AssignMemberToOjects { get; set; }

        ///<summary>
        ///Warehouse
        ///</summary>  
        public virtual DbSet<MaterialProduct> MaterialProducts { get; set; }
        public virtual DbSet<MaterialProductGroup> MaterialProductGroups { get; set; }
        public virtual DbSet<MaterialProductAttributeMain> MaterialProductAttributeMains { get; set; }
        public virtual DbSet<PackingType> PackingTypes { get; set; }
        public virtual DbSet<AttrGalaxy> AttrGalaxys { get; set; }
        public virtual DbSet<AttrGalaxyAet> AttrGalaxyAets { get; set; }
        public virtual DbSet<AttributeManager> AttributeManagers { get; set; }
        public virtual DbSet<AssetAttrGalaxy> AssetAttrGalaxys { get; set; }
        public virtual DbSet<ProductAttrGalaxy> ProductAttrGalaxys { get; set; }
        public virtual DbSet<ProductAttrExt> ProductAttrExts { get; set; }
        public virtual DbSet<AttributeManagerGalaxy> AttributeManagerGalaxys { get; set; }
        public virtual DbSet<ProductComponent> ProductComponents { get; set; }
        public virtual DbSet<MaterialProductAttributeChildren> MaterialProductAttributeChildrens { get; set; }
        public virtual DbSet<MaterialProductAssetChildren> MaterialProductAssetChildrens { get; set; }
        public virtual DbSet<MaterialType> MaterialTypes { get; set; }
        public virtual DbSet<MaterialAttribute> MaterialAttributes { get; set; }
        public virtual DbSet<MaterialFile> MaterialFiles { get; set; }
        public virtual DbSet<ProdDeliveryHeader> ProdDeliveryHeaders { get; set; }
        public virtual DbSet<ProdDeliveryDetail> ProdDeliveryDetails { get; set; }
        public virtual DbSet<MaterialStoreBatchGoods> MaterialStoreBatchGoodss { get; set; }
        public virtual DbSet<ProdReceivedHeader> ProdReceivedHeaders { get; set; }
        public virtual DbSet<ProdReceivedDetail> ProdReceivedDetails { get; set; }
        public virtual DbSet<ProdReceivedAttrValue> ProdReceivedAttrValues { get; set; }
        public virtual DbSet<ProdDeliveryAttrValue> ProdDeliveryAttrValues { get; set; }
        public virtual DbSet<StockArrangePutEntry> StockArrangePutEntrys { get; set; }
        public virtual DbSet<StockArrangePopEntry> StockArrangePopEntrys { get; set; }
        public virtual DbSet<MapStockProdIn> MapStockProdIns { get; set; }
        public virtual DbSet<ProdInStockAttrValue> ProdInStockAttrValues { get; set; }
        public virtual DbSet<MaterialInvoice> MaterialInvoices { get; set; }
        public virtual DbSet<CommonSettingGroup> CommonSettingGroups { get; set; }
        public virtual DbSet<CommonSetting> CommonSettings { get; set; }
        public virtual DbSet<LmsCommonSetting> LmsCommonSettings { get; set; }
        //public virtual DbSet<MaterialStore> MaterialStores { get; set; }
        public virtual DbSet<MaterialPaymentTicket> MaterialPaymentTickets { get; set; }
        public virtual DbSet<ProductInStock> ProductInStocks { get; set; }
        public virtual DbSet<ProductInStockExp> ProductInStockExps { get; set; }
        public virtual DbSet<ForecastProductInStock> ForecastProductInStocks { get; set; }
        public virtual DbSet<ProductEntityMapping> ProductEntityMappings { get; set; }
        public virtual DbSet<ProductEntityMappingLog> ProductEntityMappingLogs { get; set; }
        public virtual DbSet<EDMSMoveProductLog> EDMSMoveProductLogs { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<MaterialStoreImpGoodsHeader> MaterialStoreImpGoodsHeaders { get; set; }
        public virtual DbSet<MaterialStoreImpGoodsDetail> MaterialStoreImpGoodsDetails { get; set; }

        public virtual DbSet<PoSupHeader> PoSupHeaders { get; set; }
        public virtual DbSet<PoSupHeaderNotDone> PoSupHeaderNotDones { get; set; }
        public virtual DbSet<PoSupHeaderPayment> PoSupHeaderPayments { get; set; }
        public virtual DbSet<Vayxe_Customer> Vayxe_Customer { get; set; }
        //Crawler
        public virtual DbSet<CrawlerDomainConfiguration> CrawlerDomainConfigurations { get; set; }
        public virtual DbSet<CrawlerManageIpRunningBot> CrawlerManageIpRunningBots { get; set; }

        public virtual DbSet<CrawlerDomainConfigurationParam> CrawlerDomainConfigurationParams { get; set; }

        public virtual DbSet<BotSocialManagement> BotSocialManagement { get; set; }
        public virtual DbSet<BotSocialSessionLog> BotSocialSessionLog { get; set; }
        public virtual DbSet<CrawlerKeyWords> CrawlerKeyWords { get; set; }
        public virtual DbSet<BotManagements> BotManagements { get; set; }

        public virtual DbSet<ScheduleManagement> ScheduleManagements { get; set; }
        public virtual DbSet<CrawlerRunningLog> CrawlerRunningLogs { get; set; }
        ////2 Bảng yêu cầu đặt hàng mới - theo form mẫu chị Tuyến gửi 2019.06.01
        //public virtual DbSet<RequestOrderHeader> RequestOrderHeaders { get; set; }
        //public virtual DbSet<RequestOrderDetail> RequestOrderDetails { get; set; }

        //2 Bảng yêu cầu đặt hàng cũ - trước khi chị Tuyến gửi form mẫu 2019.06.01
        public virtual DbSet<RequestImpProductHeader> RequestImpProductHeaders { get; set; }
        public virtual DbSet<RequestImpProductDetail> RequestImpProductDetails { get; set; }
        public virtual DbSet<RequestPriceHeader> RequestPriceHeaders { get; set; }
        public virtual DbSet<RequestPriceDetail> RequestPriceDetails { get; set; }
        public virtual DbSet<PoSupRequestImpProduct> PoSupRequestImpProducts { get; set; }
        public virtual DbSet<RequestPoSup> RequestPoSups { get; set; }
        public virtual DbSet<cms_attachments> cms_attachments { get; set; }
        public virtual DbSet<cms_categories> cms_categories { get; set; }
        public virtual DbSet<cms_comments> cms_comments { get; set; }
        public virtual DbSet<cms_extra_fields> cms_extra_fields { get; set; }
        public virtual DbSet<cms_extra_fields_groups> cms_extra_fields_groups { get; set; }
        public virtual DbSet<cms_extra_fields_value> cms_extra_fields_value { get; set; }
        public virtual DbSet<cms_functions> cms_functions { get; set; }
        public virtual DbSet<cms_function_group> cms_function_group { get; set; }
        public virtual DbSet<cms_function_resource> cms_function_resource { get; set; }
        public virtual DbSet<cms_items> cms_items { get; set; }
        public virtual DbSet<cms_rating> cms_rating { get; set; }
        public virtual DbSet<cms_roles> cms_roles { get; set; }
        public virtual DbSet<cms_setting> cms_setting { get; set; }
        public virtual DbSet<cms_tags> cms_tags { get; set; }
        public virtual DbSet<cms_tags_xref> cms_tags_xref { get; set; }
        public virtual DbSet<CommonSettingArticle> CommonSettingArticles { get; set; }
        public virtual DbSet<SettingUserguide> SettingUserguides { get; set; }

        /// <summary>
        /// Asset
        /// </summary>
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<AssetAttribute> AssetAttributes { get; set; }
        public virtual DbSet<AssetActivity> AssetAtivitys { get; set; }
        public virtual DbSet<AssetMain> AssetMains { get; set; }
        public virtual DbSet<AssetType> AssetTypes { get; set; }
        public virtual DbSet<AssetGroup> AssetGroups { get; set; }
        public virtual DbSet<AssetInventoryHeader> AssetInventoryHeaders { get; set; }
        public virtual DbSet<AssetInventoryDetail> AssetInventoryDetails { get; set; }
        public virtual DbSet<AssetInventoryFile> AssetInventoryFiles { get; set; }
        public virtual DbSet<AssetAllocateHeader> AssetAllocateHeaders { get; set; }
        public virtual DbSet<AssetAllocateDetail> AssetAllocateDetails { get; set; }
        public virtual DbSet<AssetAllocationFile> AssetAllocationFiles { get; set; }
        public virtual DbSet<AssetBuyHeader> AssetBuyHeaders { get; set; }
        public virtual DbSet<AssetBuyDetail> AssetBuyDetails { get; set; }
        public virtual DbSet<AssetBuyFile> AssetBuyFiles { get; set; }
        public virtual DbSet<AssetTransferHeader> AssetTransferHeaders { get; set; }
        public virtual DbSet<AssetTransferDetail> AssetTransferDetails { get; set; }
        public virtual DbSet<AssetTransferFile> AssetTransferFiles { get; set; }
        public virtual DbSet<AssetRqMaintenanceRepairHeader> AssetRqMaintenanceRepairHeaders { get; set; }
        public virtual DbSet<AssetRqMaintenanceRepairDetail> AssetRqMaintenanceRepairDetails { get; set; }
        public virtual DbSet<AssetRqMaintenanceRepairFile> AssetRqMaintenanceRepairFiles { get; set; }
        public virtual DbSet<AssetMaintenanceHeader> AssetMaintenanceHeaders { get; set; }
        public virtual DbSet<AssetMaintenanceDetails> AssetMaintenanceDetailss { get; set; }
        public virtual DbSet<AssetMaintenanceFile> AssetMaintenanceFiles { get; set; }
        public virtual DbSet<AssetMaintenanceCategory> AssetMaintenanceCategorys { get; set; }
        public virtual DbSet<AssetImprovementHeader> AssetImprovementHeaders { get; set; }
        public virtual DbSet<AssetImprovementDetails> AssetImprovementDetailss { get; set; }
        public virtual DbSet<AssetImprovementFile> AssetImprovementFiles { get; set; }
        public virtual DbSet<AssetImprovementCategory> AssetImprovementCategorys { get; set; }
        public virtual DbSet<AssetCancelHeader> AssetCancelHeaders { get; set; }
        public virtual DbSet<AssetCancelDetail> AssetCancelDetails { get; set; }
        public virtual DbSet<AssetCancelFile> AssetCancelFiles { get; set; }
        public virtual DbSet<AssetLiquidationHeader> AssetLiquidationHeaders { get; set; }
        public virtual DbSet<AssetLiquidationDetail> AssetLiquidationDetails { get; set; }
        public virtual DbSet<AssetLiquidationFile> AssetLiquidationFiles { get; set; }
        public virtual DbSet<AssetRPTBrokenHeader> AssetRPTBrokenHeaders { get; set; }
        public virtual DbSet<AssetRPTBrokenDetails> AssetRPTBrokenDetails { get; set; }
        public virtual DbSet<AssetRPTBrokenFile> AssetRPTBrokenFiles { get; set; }
        public virtual DbSet<AssetRecalledHeader> AssetRecalledHeaders { get; set; }
        public virtual DbSet<AssetRecalledDetail> AssetRecalledDetails { get; set; }
        public virtual DbSet<AssetRecalledFile> AssetRecalledFiles { get; set; }


        /// <summary>
        /// Log Activity new
        /// </summary>
        public virtual DbSet<CatWorkFlow> CatWorkFlows { get; set; }
        public virtual DbSet<CatActivity> CatActivitys { get; set; }
        public virtual DbSet<ActivityLogData> ActivityLogDatas { get; set; }
        public virtual DbSet<ActivityAttrData> ActivityAttrDatas { get; set; }
        public virtual DbSet<AttrSetup> AttrSetups { get; set; }
        public virtual DbSet<WorkflowActivity> ObjectActivitys { get; set; }
        public virtual DbSet<WorkflowActivityRole> WorkflowActivityRoles { get; set; }



        /// <summary>
        /// HR
        /// </summary>
        public virtual DbSet<HRAddress> HRAddress { get; set; }
        public virtual DbSet<HRContact> HRContacts { get; set; }
        public virtual DbSet<HRContract> HRContracts { get; set; }
        public virtual DbSet<HREmployee> HREmployees { get; set; }
        public virtual DbSet<HRTrainingCourse> HRTrainingCourses { get; set; }
        public virtual DbSet<HRWorkFlows> HRWorkFlows { get; set; }
        public virtual DbSet<HRWorkingProcess> HRWorkingProcesss { get; set; }
        public virtual DbSet<HrTranningCourseFile> HrTranningCourseFiles { get; set; }

        /// <summary>
        /// Project
        /// </summary>
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectTeam> ProjectTeams { get; set; }

        public virtual DbSet<ProjectCustomer> ProjectCustomers { get; set; }
        public virtual DbSet<ProjectGantt> ProjectGantts { get; set; }
        public virtual DbSet<ProjectMember> ProjectMembers { get; set; }
        public virtual DbSet<ProjectFile> ProjectFiles { get; set; }
        public virtual DbSet<ProjectSupplier> ProjectSuppliers { get; set; }
        public virtual DbSet<ProjectNote> ProjectNotes { get; set; }
        public virtual DbSet<ProjectAppointment> ProjectAppointments { get; set; }
        //public virtual DbSet<ProjectBoard> ProjectBoards { get; set; }
        public virtual DbSet<ProjectAttribute> ProjectAttributes { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<ProjectTeamUser> ProjectTeamUsers { get; set; }

        public virtual DbSet<ProjectCusSup> ProjectCusSups { get; set; }
        public virtual DbSet<PoSaleProductDetail> PoSaleProductDetails { get; set; }
        public virtual DbSet<ProjectService> ProjectServices { get; set; }
        public virtual DbSet<ProjectServiceHeader> ProjectServiceHeaders { get; set; }
        public virtual DbSet<ProjectServiceDetail> ProjectServiceDetails { get; set; }
        public virtual DbSet<ProjectProduct> ProjectProducts { get; set; }
        public virtual DbSet<ProjectProductHeader> ProjectProductHeaders { get; set; }
        public virtual DbSet<ProjectProductDetail> ProjectProductDetails { get; set; }
        public virtual DbSet<VProjectProductRemain> VProjectProductRemains { get; set; }
        /// <summary>
        /// Card
        /// </summary>
        public virtual DbSet<WORKOSBoard> WORKOSBoards { get; set; }
        public virtual DbSet<WORKOSList> WORKOSLists { get; set; }
        public virtual DbSet<WORKOSCard> WORKOSCards { get; set; }
        public virtual DbSet<CardItemCheck> CardItemChecks { get; set; }
        public virtual DbSet<CardSubitemCheck> CardSubitemChecks { get; set; }
        public virtual DbSet<CardAttachment> CardAttachments { get; set; }
        public virtual DbSet<CardCommentList> CardCommentLists { get; set; }
        public virtual DbSet<LmsTaskCommentList> LmsTaskCommentLists { get; set; }
        public virtual DbSet<CardForWObj> CardForWObjs { get; set; }
        public virtual DbSet<CardMember> CardMembers { get; set; }
        public virtual DbSet<CardGroupUser> CardGroupUsers { get; set; }
        public virtual DbSet<CardUserActivity> CardUserActivities { get; set; }
        public virtual DbSet<CardProduct> CardProducts { get; set; }
        public virtual DbSet<CardMapping> CardMappings { get; set; }
        public virtual DbSet<JcObjectType> JcObjectTypes { get; set; }
        public virtual DbSet<JcObjectIdRelative> JcObjectIdRelatives { get; set; }
        public virtual DbSet<JcProduct> JcProducts { get; set; }
        public virtual DbSet<JcService> JcServices { get; set; }
        public virtual DbSet<SessionWorkResult> SessionWorkResults { get; set; }
        public virtual DbSet<WorkItemAssignStaff> WorkItemAssignStaffs { get; set; }
        public virtual DbSet<SessionWork> SessionWorks { get; set; }
        public virtual DbSet<JobCardLink> JobCardLinks { get; set; }



        /// <summary>
        /// Candidate
        /// </summary>
        public virtual DbSet<CandidateBasic> CandiateBasic { get; set; }
        public virtual DbSet<CandidateWorkEvent> CandidateWorkEvents { get; set; }
        public virtual DbSet<CandidateInterview> CandidateInterviews { get; set; }

        /// <summary>
        /// Staff
        /// </summary>
        public virtual DbSet<CompanyScheduleWork> CompanyScheduleWorks { get; set; }
        public virtual DbSet<StaffScheduleWork> StaffScheduleWorks { get; set; }
        public virtual DbSet<WorkShiftCheckInOut> WorkShiftCheckInOuts { get; set; }
        public virtual DbSet<ShiftLog> ShiftLogs { get; set; }
        public virtual DbSet<UserDeclareBusyOrFree> UserDeclareBusyOrFrees { get; set; }

        /// <summary>
        /// Keyword
        /// </summary>
        public virtual DbSet<GalaxyKeyword> GalaxyKeywords { get; set; }

        /// <summary>
        /// Google API
        /// </summary>
        public virtual DbSet<TokenManager> TokenManagers { get; set; }
        public virtual DbSet<CountRequestGoogle> CountRequestGoogle { get; set; }

        /// <summary>
        /// Addon app
        /// </summary>
        public virtual DbSet<AddonApp> AddonApps { get; set; }
        public virtual DbSet<AddonAppServer> AddonAppServers { get; set; }
        public virtual DbSet<AppVendor> AppVendors { get; set; }
        public virtual DbSet<HolidayDate> HolidayDates { get; set; }
        public virtual DbSet<MobiFunctionJobCardList> MobiFunctionJobCardLists { get; set; }

        /// <summary>
        /// Dispatches
        /// </summary>
        public virtual DbSet<DispatchesCategory> DispatchesCategorys { get; set; }
        public virtual DbSet<DispatchesHeader> DispatchesHeaders { get; set; }
        public virtual DbSet<DispatchTrackingProcess> DispatchTrackingProcesss { get; set; }
        public virtual DbSet<DispatchesMemberActivity> DispatchesMemberActivitys { get; set; }
        public virtual DbSet<DispatchesFileACT> DispatchesFileACTs { get; set; }
        public virtual DbSet<DispatchesCommentACT> DispatchesCommentACTs { get; set; }
        public virtual DbSet<DispatchesUser> DispatchesUsers { get; set; }
        public virtual DbSet<DispatchesWeekWorkingScheduler> DispatchesWeekWorkingSchedulerss { get; set; }


        /// <summary>
        /// Building
        /// </summary>
        public virtual DbSet<JCKMaterialsComsume> JCKMaterialsComsumes { get; set; }
        public virtual DbSet<JCTrackingBuilding> JCTrackingBuildings { get; set; }
        public virtual DbSet<JCTrackingMedia> JCTrackingMedias { get; set; }
        //public virtual DbSet<ProjectBuilding> ProjectBuildings { get; set; }


        //Face Id
        public virtual DbSet<FaceFaceId> FaceFaceIds { get; set; }

        public virtual DbSet<ObeListDevice> ObelistDevices { get; set; }
        public virtual DbSet<ObeAiRecognitionTracking> ObeAiRecognitionTrackings { get; set; }
        public virtual DbSet<ObeAccount> ObeAccounts { get; set; }


        //Vicem
        public virtual DbSet<VcSupplierTradeRelation> VcSupplierTradeRelations { get; set; }
        public virtual DbSet<VcTransporter> VcTransporters { get; set; }

        public virtual DbSet<VcProductCat> VcProductCats { get; set; }
        public virtual DbSet<VcWorkCheck> VcWorkChecks { get; set; }
        public virtual DbSet<VcSettingRoute> VcSettingRoutes { get; set; }
        public virtual DbSet<VcWorkPlan> VcWorkPlans { get; set; }
        public virtual DbSet<VcWorkPlanLog> VcWorkPlanLogs { get; set; }
        public virtual DbSet<VcCustomerCare> VcCustomerCares { get; set; }
        public virtual DbSet<VcLeaderApprove> VcLeaderApproves { get; set; }
        public virtual DbSet<VcStoreIdea> VcStoreIdeas { get; set; }
        public virtual DbSet<VcCustomerDeclareInfo> VcCustomerDeclareInfos { get; set; }
        public virtual DbSet<VcCustomerDeclareHeaderInfo> VcCustomerDeclareHeaderInfos { get; set; }
        public virtual DbSet<VcDriver> VcDrivers { get; set; }
        public virtual DbSet<VcSOSInfo> VcSOSInfos { get; set; }
        public virtual DbSet<VcSOSMedia> VcSOSMedias { get; set; }
        public virtual DbSet<VcFcm> VcFcms { get; set; }
        public virtual DbSet<VcFcmMessage> VcFcmMessages { get; set; }
        public virtual DbSet<VcAppAccessLog> VcAppAccessLogs { get; set; }
        public virtual DbSet<VcGisTable> VcGisTables { get; set; }
        public virtual DbSet<VcCustomerCareLastMonth> VcCustomerCareLastMonths { get; set; }

        //Tin nội bộ Vicem
        public virtual DbSet<VCJnanaFile> VCJnanaFiles { get; set; }
        public virtual DbSet<VCJnanaNewsArticle> VCJnanaNewsArticles { get; set; }
        public virtual DbSet<VCJnanaNewsArticleFile> VCJnanaNewsArticleFiles { get; set; }
        public virtual DbSet<VCJnanaNewsCat> VCJnanaNewsCats { get; set; }
        public virtual DbSet<VCJnanaFcm> VCJnanaFcms { get; set; }
        public virtual DbSet<VCJnanaFcmMessage> VCJnanaFcmMessages { get; set; }


        /// <summary>
        /// Facco
        /// </summary>
        public virtual DbSet<FacoProductCat> FacoProductCats { get; set; }
        public virtual DbSet<OperationOnlineSupport> OperationOnlineSupports { get; set; }
        public virtual DbSet<OperationOnlineSupportTracking> OperationOnlineSupportTrackings { get; set; }
        public virtual DbSet<SetCompanyMenu> SetCompanyMenus { get; set; }

        //public object Remooc_Fcm_Tokens { get; set; }
        public virtual DbSet<ProdPackageReceived> ProdPackageReceiveds { get; set; }
        public virtual DbSet<ProdPackageDelivery> ProdPackageDeliverys { get; set; }

        /// <summary>
        /// Romooc
        /// </summary>
        public virtual DbSet<RmSOSInfo> RmSOSInfos { get; set; }
        public virtual DbSet<RmGisTable> RmGisTables { get; set; }
        public virtual DbSet<RmSOSMedia> RmSOSMedias { get; set; }
        public virtual DbSet<RmJnanaFile> RmJnanaFiles { get; set; }
        public virtual DbSet<RmJnanaNewsArticle> RmJnanaNewsArticles { get; set; }
        public virtual DbSet<RmJnanaNewsArticleFile> RmJnanaNewsArticleFiles { get; set; }
        public virtual DbSet<RmJnanaNewsCat> RmJnanaNewsCats { get; set; }
        public virtual DbSet<RmJnanaFcm> RmJnanaFcms { get; set; }
        public virtual DbSet<RmJnanaFcmMessage> RmJnanaFcmMessages { get; set; }
        public virtual DbSet<RmRemoocCurrentPosition> RmRemoocCurrentPositions { get; set; }
        public virtual DbSet<RmRomoocExtrafield> RmRomoocExtrafields { get; set; }
        public virtual DbSet<RmRemoocPacking> RmRemoocPackings { get; set; }
        public virtual DbSet<RmRemoocRemooc> RmRemoocRemoocs { get; set; }
        public virtual DbSet<RmRemoocTracking> RmRemoocTrackings { get; set; }
        public virtual DbSet<RmRemoocTractor> RmRemoocTractors { get; set; }
        public virtual DbSet<RmRemoocFcm> RmRemoocFcms { get; set; }
        public virtual DbSet<RmRomoocDriver> RmRomoocDrivers { get; set; }
        public virtual DbSet<RmRemoocFcmMesage> RmRemoocFcmMesages { get; set; }
        public virtual DbSet<RmCommandOrderTruck> RmCommandOrderTrucks { get; set; }
        public virtual DbSet<RmECompany> RmECompanys { get; set; }
        public virtual DbSet<RmVayxeCatSevices> RmVayxeCatSevicess { get; set; }
        public virtual DbSet<RmVayxeTableCostHeader> RmVayxeTableCostHeaders { get; set; }
        public virtual DbSet<RmVayxeTableCostDetails> RmVayxeTableCostDetailss { get; set; }
        public virtual DbSet<RmVayxeBookChecking> RmVayxeBookCheckings { get; set; }
        public virtual DbSet<RmVayxeBookServiceDetails> RmVayxeBookServiceDetailss { get; set; }
        public virtual DbSet<RmVayxeBookMaterialDetails> RmVayxeBookMaterialDetailss { get; set; }
        public virtual DbSet<RmVayxeVendor> RmVayxeVendors { get; set; }
        public virtual DbSet<RmVayxeMaterialGoods> RmVayxeMaterialGoodss { get; set; }
        public virtual DbSet<RmJnanaApiGoogleServices> RmJnanaApiGoogleServicess { get; set; }
        public virtual DbSet<RmJnanaCountRequestGoogle> RmJnanaCountRequestGoogles { get; set; }
        public virtual DbSet<RmDriverActivityLog> RmDriverActivityLogs { get; set; }
        public virtual DbSet<RmHrEmployee> RmHrEmployees { get; set; }
        public virtual DbSet<RmCancelTracking> RmCancelTrackings { get; set; }
        public virtual DbSet<RmCommentSetting> RmCommentSettings { get; set; }

        public virtual DbSet<IconManager> IconManagers { get; set; }
        public virtual DbSet<SubProduct> SubProducts { get; set; }
        public virtual DbSet<ProductLotFile> ProductLotFiles { get; set; }

        public virtual DbSet<LotProduct> LotProducts { get; set; }
        public virtual DbSet<LotProductDetail> LotProductDetails { get; set; }
        public virtual DbSet<PoBuyerHeader> PoBuyerHeaders { get; set; }
        public virtual DbSet<PoBuyerHeaderNotDone> PoBuyerHeaderNotDones { get; set; }
        public virtual DbSet<PoBuyerHeaderPayment> PoBuyerHeaderPayments { get; set; }
        public virtual DbSet<PoBuyerDetail> PoBuyerDetails { get; set; }
        public virtual DbSet<PoSupUpdateTracking> PoSupUpdateTrackings { get; set; }
        public virtual DbSet<PoCusUpdateTracking> PoCusUpdateTrackings { get; set; }

        ///<summary>
        ///FUND
        ///</sumary>
        public virtual DbSet<FundAccEntry> FundAccEntrys { get; set; }
        public virtual DbSet<ParamForWarning> ParamForWarnings { get; set; }
        public virtual DbSet<FundExchagRate> FundExchagRates { get; set; }
        public virtual DbSet<FundCurrency> FundCurrencys { get; set; }
        public virtual DbSet<FundCatReptExps> FundCatReptExpss { get; set; }
        public virtual DbSet<FundFiles> FundFiless { get; set; }
        public virtual DbSet<FundAccEntryTracking> FundAccEntryTrackings { get; set; }
        public virtual DbSet<ProductCostDetail> ProductCostDetails { get; set; }
        public virtual DbSet<CostTableLog> CostTableLogs { get; set; }
        public virtual DbSet<ProductCostHeader> ProductCostHeaders { get; set; }
        public virtual DbSet<ProductQrCode> ProductQrCodes { get; set; }
        public virtual DbSet<FundRelativeObjMng> FundRelativeObjMngs { get; set; }
        public virtual DbSet<FundLoaddingSMSBank> FundLoaddingSMSBanks { get; set; }



        /// IOT_Table
        public virtual DbSet<IotCarInOut> IotCarInOuts { get; set; }
        public virtual DbSet<IotWarningSetting> IotWarningSettings { get; set; }
        public virtual DbSet<IotAnalysis_Action> IotAnalysis_Actions { get; set; }
        public virtual DbSet<IotSensor> IotSensors { get; set; }
        public virtual DbSet<IotSetUpAlert> IotSetUpAlerts { get; set; }
        public virtual DbSet<IotDeviceInfo> IotDeviceInfos { get; set; }
        public virtual DbSet<ZoneSetup> ZoneSetups { get; set; }
        public virtual DbSet<ZoneDevicePlacement> ZoneDevicePlacements { get; set; }

        ///Phần Share File
        public virtual DbSet<EDMSObjectShareFile> EDMSObjectShareFiles { get; set; }

        ///Phần Dịch Vụ
        ///
        public virtual DbSet<ServiceCategoryAttribute> ServiceCategoryAttributes { get; set; }
        public virtual DbSet<ServiceCategoryGroup> ServiceCategoryGroups { get; set; }
        public virtual DbSet<ServiceCategoryType> ServiceCategoryTypes { get; set; }
        public virtual DbSet<ServiceCategoryCostCondition> ServiceCategoryCostConditions { get; set; }
        public virtual DbSet<ServiceCategoryCostHeader> ServiceCategoryCostHeaders { get; set; }

        //Syncfusion
        public virtual DbSet<AseanDocument> AseanDocuments { get; set; }
        public virtual DbSet<LogChangeDocument> LogChangeDocuments { get; set; }

        /// <summary>
        /// Work Flow
        /// </summary>
        public virtual DbSet<WfObject> WfObjects { get; set; }
        public virtual DbSet<WorkFlow> WorkFlows { get; set; }
        public virtual DbSet<WorkFlowRule> WorkFlowRules { get; set; }
        public virtual DbSet<ProgressTracking> ProgressTrackings { get; set; }
        /// <summary>
        /// Zoom Meeting
        /// </summary>
        public virtual DbSet<ZoomManage> ZoomManages { get; set; }
        public virtual DbSet<ZoomReportError> ZoomReportErrors { get; set; }

        /// <summary>
        /// Salary table
        /// </summary>
        public virtual DbSet<SalaryTableHeader> SalaryTableHeaders { get; set; }
        public virtual DbSet<SalaryTableDetail> SalaryTableDetails { get; set; }
        public virtual DbSet<SalaryTableAllowance> SalaryTableAllowances { get; set; }
        public virtual DbSet<SalaryEmployeeMonth> SalaryEmployeeMonths { get; set; }

        /// <summary>
        /// Danh sách đối tượng
        /// </summary>
        /// 
        public virtual DbSet<VAllObject> VAllObjects { get; set; }
        public virtual DbSet<VAmchartCountBuy> VAmchartCountBuys { get; set; }
        public virtual DbSet<VAmchartCountSale> VAmchartCountSales { get; set; }
        public virtual DbSet<VAmchartCountCustomer> VAmchartCountCustomers { get; set; }
        public virtual DbSet<VAmchartCountSupplier> VAmchartCountSuppliers { get; set; }
        public virtual DbSet<VAmchartCountProject> VAmchartCountProjects { get; set; }
        public virtual DbSet<VAmchartCountEmployee> VAmchartCountEmployees { get; set; }
        public virtual DbSet<VHighchartFund> VHighchartFunds { get; set; }
        public virtual DbSet<VHighchartProd> VHighchartProds { get; set; }
        public virtual DbSet<VListBoard> VListBoards { get; set; }
        public virtual DbSet<VCardProcess> VCardProcesss { get; set; }

        /// <summary>
        /// Log message
        /// </summary>
        /// 
        public virtual DbSet<LogMessage> LogMessages { get; set; }


        /// <summary>
        /// Urenco
        /// </summary>
        /// 
        public virtual DbSet<UrencoCarMaintenanceHeader> UrencoCarMaintenanceHeaders { get; set; }
        public virtual DbSet<UrencoCarCostHeader> UrencoCarCostHeaders { get; set; }
        public virtual DbSet<UrencoCarCostDetail> UrencoCarCostDetails { get; set; }
        public virtual DbSet<UrencoCarManager> UrencoCarManagers { get; set; }

        /// <summary>
        /// Excel Expression
        /// </summary>
        /// 
        public virtual DbSet<ExcelExpression> ExcelExpressions { get; set; }

        /// <summary>
        /// Allowance
        /// </summary>
        /// 
        public virtual DbSet<AllowanceCategory> AllowanceCategorys { get; set; }
        public virtual DbSet<AllowanceParam> AllowanceParams { get; set; }
        public virtual DbSet<AllowanceContraint> AllowanceContraints { get; set; }
        public virtual DbSet<AllowanceEmployeeAccept> AllowanceEmployeeAccepts { get; set; }
        public virtual DbSet<AllowanceEmployeeParam> AllowanceEmployeeParams { get; set; }
        public virtual DbSet<AllowanceEmployeeMonth> AllowanceEmployeeMonths { get; set; }

        /// <summary>
        /// DashBoard
        /// </summary>
        /// 
        public virtual DbSet<DashboardDataJson> DashboardDataJsons { get; set; }

        /// <summary>
        /// A365
        /// </summary>
        /// 
        public virtual DbSet<UserA365> UserA365s { get; set; }
        /// <summary>
        /// phan luon QuangHanh
        /// </summary>
        /// 
        public virtual DbSet<PaySheet> PaySheets { get; set; }
        public virtual DbSet<CameraRoom> CameraRooms { get; set; }
        
        #region cmt

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //            => optionsBuilder.UseSqlServer("Server=117.6.131.222,1437;Database=CMS_TriAnLietSi;Uid=admin;Password=Vietnam@799;TrustServerCertificate=True");

        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<AdGroup>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__ad_group__3213E83F4316F928");

                 entity.ToTable("ad_group");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.CreatedBy).HasColumnName("created_by");
                 entity.Property(e => e.CreatedDate)
                     .HasDefaultValueSql("(getdate())")
                     .HasColumnType("datetime")
                     .HasColumnName("created_date");
                 entity.Property(e => e.Description)
                     .HasMaxLength(500)
                     .HasColumnName("description");
                 entity.Property(e => e.GroupName)
                     .HasMaxLength(255)
                     .HasColumnName("group_name");
                 entity.Property(e => e.GroupParent).HasColumnName("group_parent");
                 entity.Property(e => e.IsActive)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("is_active");
                 entity.Property(e => e.IsDelete)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("is_delete");
                 entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
                 entity.Property(e => e.ModifiedDate)
                     .HasColumnType("datetime")
                     .HasColumnName("modified_date");
             });

             modelBuilder.Entity<AdUser>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__ad_group__3213E83F46E78A0C");

                 entity.ToTable("ad_user");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.CreatedBy).HasColumnName("created_by");
                 entity.Property(e => e.CreatedDate)
                     .HasDefaultValueSql("(getdate())")
                     .HasColumnType("datetime")
                     .HasColumnName("created_date");
                 entity.Property(e => e.Email)
                     .HasMaxLength(255)
                     .HasColumnName("email");
                 entity.Property(e => e.FullName)
                     .HasMaxLength(255)
                     .HasColumnName("full_name");
                 entity.Property(e => e.IsActive)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("is_active");
                 entity.Property(e => e.IsDelete)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("is_delete");
                 entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
                 entity.Property(e => e.ModifiedDate)
                     .HasColumnType("datetime")
                     .HasColumnName("modified_date");
                 entity.Property(e => e.PassSalt)
                     .HasMaxLength(50)
                     .HasColumnName("pass_salt");
                 entity.Property(e => e.Password)
                     .HasMaxLength(255)
                     .HasColumnName("password");
                 entity.Property(e => e.ResetCount).HasColumnName("reset_count");
                 entity.Property(e => e.ResetDate)
                     .HasColumnType("datetime")
                     .HasColumnName("reset_date");
                 entity.Property(e => e.RoleId).HasColumnName("role_id");
                 entity.Property(e => e.UserName)
                     .IsRequired()
                     .HasMaxLength(255)
                     .HasColumnName("user_name");
             });

             modelBuilder.Entity<AdUserGroup>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__ad_user___3213E83F4AB81AF0");

                 entity.ToTable("ad_user_group");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.CreatedBy).HasColumnName("created_by");
                 entity.Property(e => e.CreatedDate)
                     .HasDefaultValueSql("(getdate())")
                     .HasColumnType("datetime")
                     .HasColumnName("created_date");
                 entity.Property(e => e.GroupId).HasColumnName("group_id");
                 entity.Property(e => e.IsActive)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("is_active");
                 entity.Property(e => e.IsDelete)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("is_delete");
                 entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
                 entity.Property(e => e.ModifiedDate)
                     .HasColumnType("datetime")
                     .HasColumnName("modified_date");
                 entity.Property(e => e.UserId).HasColumnName("user_id");
             });

             modelBuilder.Entity<AdUserInfo>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__ad_user___3213E83F4F7CD00D");

                 entity.ToTable("ad_user_info");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.Address)
                     .HasMaxLength(500)
                     .HasColumnName("address");
                 entity.Property(e => e.Birthday)
                     .HasColumnType("datetime")
                     .HasColumnName("birthday");
                 entity.Property(e => e.CreatedDate)
                     .HasDefaultValueSql("(getdate())")
                     .HasColumnType("datetime")
                     .HasColumnName("created_date");
                 entity.Property(e => e.Gender).HasColumnName("gender");
                 entity.Property(e => e.HomePhone)
                     .HasMaxLength(25)
                     .IsUnicode(false)
                     .HasColumnName("home_phone");
                 entity.Property(e => e.IsDelete)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("is_delete");
                 entity.Property(e => e.MobilePhone)
                     .HasMaxLength(25)
                     .IsUnicode(false)
                     .HasColumnName("mobile_phone");
                 entity.Property(e => e.ModifiedDate)
                     .HasColumnType("datetime")
                     .HasColumnName("modified_date");
                 entity.Property(e => e.UserId).HasColumnName("user_id");
             });

             modelBuilder.Entity<AdUserLog>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__ad_user___3213E83F6383C8BA");

                 entity.ToTable("ad_user_log");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.Content)
                     .HasMaxLength(500)
                     .HasColumnName("content");
                 entity.Property(e => e.CreatedBy).HasColumnName("created_by");
                 entity.Property(e => e.CreatedDate)
                     .HasDefaultValueSql("(getdate())")
                     .HasColumnType("datetime")
                     .HasColumnName("created_date");
                 entity.Property(e => e.FullName)
                     .HasMaxLength(50)
                     .HasColumnName("full_name");
                 entity.Property(e => e.LogType)
                     .HasDefaultValueSql("((1))")
                     .HasComment("Log Type: 1. Login, 2. Create, 3. Update, 4. Delete")
                     .HasColumnName("log_type");
                 entity.Property(e => e.UserId).HasColumnName("user_id");
                 entity.Property(e => e.UserIp)
                     .HasMaxLength(20)
                     .HasColumnName("user_ip");
             });

             modelBuilder.Entity<AdUserReset>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__ad_user___3213E83F5DCAEF64");

                 entity.ToTable("ad_user_reset");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.Activation)
                     .HasMaxLength(50)
                     .HasColumnName("activation");
                 entity.Property(e => e.CreatedDate)
                     .HasDefaultValueSql("(getdate())")
                     .HasColumnType("datetime")
                     .HasColumnName("created_date");
                 entity.Property(e => e.Email)
                     .HasMaxLength(255)
                     .HasColumnName("email");
                 entity.Property(e => e.ExpriedDate)
                     .HasDefaultValueSql("(getdate()+(1))")
                     .HasColumnType("datetime")
                     .HasColumnName("expried_date");
                 entity.Property(e => e.IsConfirmed)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("is_confirmed");
                 entity.Property(e => e.ResetLink)
                     .HasMaxLength(300)
                     .HasColumnName("reset_link");
                 entity.Property(e => e.ResetType)
                     .HasComment("1. Reset password | 2. Activation")
                     .HasColumnName("reset_type");
                 entity.Property(e => e.UserId).HasColumnName("user_id");
                 entity.Property(e => e.UserName)
                     .HasMaxLength(255)
                     .HasColumnName("user_name");
             });

             modelBuilder.Entity<CmsAttachment>(entity =>
             {
                 entity.ToTable("cms_attachments");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.FileName)
                     .HasMaxLength(255)
                     .HasColumnName("file_name");
                 entity.Property(e => e.FilePath)
                     .HasMaxLength(255)
                     .HasColumnName("file_path");
                 entity.Property(e => e.FileType)
                     .HasMaxLength(255)
                     .HasColumnName("file_type");
                 entity.Property(e => e.FileUrl)
                     .HasMaxLength(255)
                     .HasColumnName("file_url");
                 entity.Property(e => e.Hits).HasColumnName("hits");
                 entity.Property(e => e.ItemId).HasColumnName("item_id");
                 entity.Property(e => e.Title)
                     .HasMaxLength(255)
                     .HasColumnName("title");
                 entity.Property(e => e.TitleAttribute)
                     .HasMaxLength(255)
                     .HasColumnName("title_attribute");
             });

             modelBuilder.Entity<CmsCategory>(entity =>
             {
                 entity.ToTable("cms_categories");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.Access).HasColumnName("access");
                 entity.Property(e => e.Alias)
                     .HasMaxLength(255)
                     .HasColumnName("alias");
                 entity.Property(e => e.Description)
                     .HasMaxLength(4000)
                     .HasColumnName("description");
                 entity.Property(e => e.ExtraFieldsGroup).HasColumnName("extra_fields_group");
                 entity.Property(e => e.Image)
                     .HasMaxLength(255)
                     .HasColumnName("image");
                 entity.Property(e => e.Language)
                     .HasMaxLength(10)
                     .IsUnicode(false)
                     .HasColumnName("language");
                 entity.Property(e => e.Name)
                     .IsRequired()
                     .HasMaxLength(255)
                     .HasColumnName("name");
                 entity.Property(e => e.Ordering).HasColumnName("ordering");
                 entity.Property(e => e.Params).HasColumnName("params");
                 entity.Property(e => e.Parent).HasColumnName("parent");
                 entity.Property(e => e.Plugins).HasColumnName("plugins");
                 entity.Property(e => e.Published)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("published");
                 entity.Property(e => e.Template).HasColumnName("template");
                 entity.Property(e => e.Trash)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("trash");
             });

             modelBuilder.Entity<CmsComment>(entity =>
             {
                 entity.ToTable("cms_comments");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.CommentDate)
                     .HasColumnType("datetime")
                     .HasColumnName("comment_date");
                 entity.Property(e => e.CommentEmail)
                     .HasMaxLength(255)
                     .HasColumnName("comment_email");
                 entity.Property(e => e.CommentText).HasColumnName("comment_text");
                 entity.Property(e => e.CommentTitle)
                     .HasMaxLength(1000)
                     .HasColumnName("comment_title");
                 entity.Property(e => e.CommentUrl)
                     .HasMaxLength(255)
                     .HasColumnName("comment_url");
                 entity.Property(e => e.ItemId).HasColumnName("item_id");
                 entity.Property(e => e.Published)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("published");
                 entity.Property(e => e.UserId).HasColumnName("user_id");
                 entity.Property(e => e.UserName)
                     .HasMaxLength(255)
                     .HasColumnName("user_name");
             });

             modelBuilder.Entity<CmsExtraField>(entity =>
             {
                 entity.ToTable("cms_extra_fields");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.Group).HasColumnName("group");
                 entity.Property(e => e.Name)
                     .IsRequired()
                     .HasMaxLength(255)
                     .HasColumnName("name");
                 entity.Property(e => e.Ordering).HasColumnName("ordering");
                 entity.Property(e => e.Published)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("published");
                 entity.Property(e => e.Type)
                     .HasMaxLength(255)
                     .HasColumnName("type");
                 entity.Property(e => e.Value).HasColumnName("value");
             });

             modelBuilder.Entity<CmsExtraFieldsGroup>(entity =>
             {
                 entity.ToTable("cms_extra_fields_groups");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.Name)
                     .HasMaxLength(255)
                     .HasColumnName("name");
             });

             modelBuilder.Entity<CmsExtraFieldsValue>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__cms_bann__3213E83F71D1E811");

                 entity.ToTable("cms_extra_fields_value");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.CreatedBy).HasColumnName("created_by");
                 entity.Property(e => e.CreatedDate)
                     .HasColumnType("datetime")
                     .HasColumnName("created_date");
                 entity.Property(e => e.DatePost)
                     .HasColumnType("datetime")
                     .HasColumnName("date_post");
                 entity.Property(e => e.FieldGroup)
                     .HasComment("Vị trí")
                     .HasColumnName("field_group");
                 entity.Property(e => e.FieldValue)
                     .HasComment("Tiêu đề")
                     .HasColumnName("field_value");
                 entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
                 entity.Property(e => e.ModifiedDate)
                     .HasColumnType("datetime")
                     .HasColumnName("modified_date");
                 entity.Property(e => e.Ordering)
                     .HasComment("Thứ tự")
                     .HasColumnName("ordering");
                 entity.Property(e => e.Publish)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("publish");
                 entity.Property(e => e.Trash)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("trash");
             });

             modelBuilder.Entity<CmsFunction>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__cms_func__3213E83F7C4F7684");

                 entity.ToTable("cms_functions");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.Created)
                     .HasColumnType("datetime")
                     .HasColumnName("created");
                 entity.Property(e => e.CreatedBy).HasColumnName("created_by");
                 entity.Property(e => e.Description)
                     .HasMaxLength(1000)
                     .HasColumnName("description");
                 entity.Property(e => e.Flag).HasColumnName("flag");
                 entity.Property(e => e.Language)
                     .HasMaxLength(10)
                     .IsUnicode(false)
                     .HasColumnName("language");
                 entity.Property(e => e.Modified)
                     .HasColumnType("datetime")
                     .HasColumnName("modified");
                 entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
                 entity.Property(e => e.Title)
                     .HasMaxLength(500)
                     .HasColumnName("title");
             });

             modelBuilder.Entity<CmsFunctionGroup>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__cms_func__3213E83F03F0984C");

                 entity.ToTable("cms_function_group");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.Add)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("add");
                 entity.Property(e => e.Created)
                     .HasColumnType("datetime")
                     .HasColumnName("created");
                 entity.Property(e => e.CreatedBy).HasColumnName("created_by");
                 entity.Property(e => e.Delete)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("delete");
                 entity.Property(e => e.Full)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("full");
                 entity.Property(e => e.FunctionId).HasColumnName("functionId");
                 entity.Property(e => e.GroupId).HasColumnName("groupId");
                 entity.Property(e => e.Modified)
                     .HasColumnType("datetime")
                     .HasColumnName("modified");
                 entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
                 entity.Property(e => e.Status).HasColumnName("status");
                 entity.Property(e => e.Update)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("update");
                 entity.Property(e => e.View)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("view");
             });

             modelBuilder.Entity<CmsFunctionResource>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__cms_func__3213E83F0C85DE4D");

                 entity.ToTable("cms_function_resource");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.CategoryId).HasColumnName("categoryId");
                 entity.Property(e => e.Created)
                     .HasColumnType("datetime")
                     .HasColumnName("created");
                 entity.Property(e => e.CreatedBy).HasColumnName("created_by");
                 entity.Property(e => e.FunctionId).HasColumnName("functionId");
                 entity.Property(e => e.Modified)
                     .HasColumnType("datetime")
                     .HasColumnName("modified");
                 entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
                 entity.Property(e => e.Status).HasColumnName("status");
             });

             modelBuilder.Entity<CmsItem>(entity =>
             {
                 entity.ToTable("cms_items");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.Access).HasColumnName("access");
                 entity.Property(e => e.Alias)
                     .HasMaxLength(1000)
                     .HasColumnName("alias");
                 entity.Property(e => e.CatId).HasColumnName("cat_id");
                 entity.Property(e => e.CheckedOut).HasColumnName("checked_out");
                 entity.Property(e => e.CheckedOutTime)
                     .HasColumnType("datetime")
                     .HasColumnName("checked_out_time");
                 entity.Property(e => e.Created)
                     .HasDefaultValueSql("(getdate())")
                     .HasColumnType("datetime")
                     .HasColumnName("created");
                 entity.Property(e => e.CreatedBy).HasColumnName("created_by");
                 entity.Property(e => e.CreatedByAlias)
                     .HasMaxLength(255)
                     .HasColumnName("created_by_alias");
                 entity.Property(e => e.DatePost)
                     .HasDefaultValueSql("(getdate())")
                     .HasColumnType("datetime")
                     .HasColumnName("date_post");
                 entity.Property(e => e.ExtraFields).HasColumnName("extra_fields");
                 entity.Property(e => e.ExtraFieldsSearch)
                     .HasMaxLength(255)
                     .HasColumnName("extra_fields_search");
                 entity.Property(e => e.Featured).HasColumnName("featured");
                 entity.Property(e => e.FeaturedOrdering)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("featured_ordering");
                 entity.Property(e => e.FullText).HasColumnName("full_text");
                 entity.Property(e => e.Gallery)
                     .HasMaxLength(255)
                     .HasColumnName("gallery");
                 entity.Property(e => e.Hits)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("hits");
                 entity.Property(e => e.ImageCaption)
                     .HasMaxLength(500)
                     .HasColumnName("image_caption");
                 entity.Property(e => e.ImageCredits)
                     .HasMaxLength(255)
                     .HasColumnName("image_credits");
                 entity.Property(e => e.IntroText).HasColumnName("intro_text");
                 entity.Property(e => e.Language)
                     .HasMaxLength(10)
                     .IsUnicode(false)
                     .HasColumnName("language");
                 entity.Property(e => e.MetaData)
                     .HasMaxLength(1000)
                     .HasColumnName("meta_data");
                 entity.Property(e => e.MetaDesc)
                     .HasMaxLength(1000)
                     .HasColumnName("meta_desc");
                 entity.Property(e => e.MetaKey)
                     .HasMaxLength(1000)
                     .HasColumnName("meta_key");
                 entity.Property(e => e.Modified)
                     .HasColumnType("datetime")
                     .HasColumnName("modified");
                 entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
                 entity.Property(e => e.Ordering).HasColumnName("ordering");
                 entity.Property(e => e.Params).HasColumnName("params");
                 entity.Property(e => e.Plugins).HasColumnName("plugins");
                 entity.Property(e => e.PublishDown)
                     .HasColumnType("datetime")
                     .HasColumnName("publish_down");
                 entity.Property(e => e.PublishUp)
                     .HasColumnType("datetime")
                     .HasColumnName("publish_up");
                 entity.Property(e => e.Published)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("published");
                 entity.Property(e => e.Template).HasColumnName("template");
                 entity.Property(e => e.Title)
                     .HasMaxLength(1000)
                     .HasColumnName("title");
                 entity.Property(e => e.Trash)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("trash");
                 entity.Property(e => e.Video)
                     .HasMaxLength(500)
                     .HasColumnName("video");
                 entity.Property(e => e.VideoCaption)
                     .HasMaxLength(500)
                     .HasColumnName("video_caption");
                 entity.Property(e => e.VideoCredits)
                     .HasMaxLength(255)
                     .HasColumnName("video_credits");
             });

             modelBuilder.Entity<CmsRating>(entity =>
             {
                 entity.ToTable("cms_rating");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.ItemId).HasColumnName("item_id");
                 entity.Property(e => e.Lastip)
                     .HasMaxLength(50)
                     .IsUnicode(false)
                     .HasColumnName("lastip");
                 entity.Property(e => e.RatingCount).HasColumnName("rating_count");
                 entity.Property(e => e.RatingSum).HasColumnName("rating_sum");
             });

             modelBuilder.Entity<CmsRole>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__cms_role__3213E83F00200768");

                 entity.ToTable("cms_roles");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.Created)
                     .HasColumnType("datetime")
                     .HasColumnName("created");
                 entity.Property(e => e.CreatedBy).HasColumnName("created_by");
                 entity.Property(e => e.Modified)
                     .HasColumnType("datetime")
                     .HasColumnName("modified");
                 entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");
                 entity.Property(e => e.Name)
                     .HasMaxLength(500)
                     .HasColumnName("name");
                 entity.Property(e => e.Rank).HasColumnName("rank");
             });

             modelBuilder.Entity<CmsSetting>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__cms_sett__3213E83F2FCF1A8A");

                 entity.ToTable("cms_setting");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.Name)
                     .HasMaxLength(255)
                     .HasColumnName("name");
                 entity.Property(e => e.Ordering).HasColumnName("ordering");
                 entity.Property(e => e.Published)
                     .HasDefaultValueSql("((1))")
                     .HasColumnName("published");
                 entity.Property(e => e.Value).HasColumnName("value");
             });

             modelBuilder.Entity<CmsTag>(entity =>
             {
                 entity.ToTable("cms_tags");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.Name)
                     .HasMaxLength(255)
                     .HasColumnName("name");
                 entity.Property(e => e.Published)
                     .HasDefaultValueSql("((0))")
                     .HasColumnName("published");
             });

             modelBuilder.Entity<CmsTagsXref>(entity =>
             {
                 entity.ToTable("cms_tags_xref");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.ItemId).HasColumnName("item_id");
                 entity.Property(e => e.TagId).HasColumnName("tag_id");
             });

             modelBuilder.Entity<Statistic>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__static__3213E83F151B244E");

                 entity.ToTable("statistic", tb => tb.HasTrigger("before_statistic_insert"));

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.SessionId)
                     .HasMaxLength(100)
                     .IsUnicode(false)
                     .HasColumnName("session_id");
                 entity.Property(e => e.VisitIp)
                     .HasMaxLength(20)
                     .IsUnicode(false)
                     .HasColumnName("visit_ip");
                 entity.Property(e => e.VisitTime)
                     .HasColumnType("datetime")
                     .HasColumnName("visit_time");
             });

             modelBuilder.Entity<StatisticHist>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__statisti__3213E83FB96ACB24");

                 entity.ToTable("statistic_hist");

                 entity.Property(e => e.Id)
                     .ValueGeneratedNever()
                     .HasColumnName("id");
                 entity.Property(e => e.SessionId)
                     .HasMaxLength(100)
                     .IsUnicode(false)
                     .HasColumnName("session_id");
                 entity.Property(e => e.VisitIp)
                     .HasMaxLength(20)
                     .IsUnicode(false)
                     .HasColumnName("visit_ip");
                 entity.Property(e => e.VisitTime)
                     .HasColumnType("datetime")
                     .HasColumnName("visit_time");
             });

             modelBuilder.Entity<StatisticRef>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__Counter__3214EC071BC821DD");

                 entity.ToTable("statistic_ref");

                 entity.Property(e => e.Id).HasColumnName("id");
                 entity.Property(e => e.StatisticId).HasColumnName("statistic_id");
                 entity.Property(e => e.UrlRef)
                     .HasMaxLength(500)
                     .HasColumnName("url_ref");
                 entity.Property(e => e.VisitTime)
                     .HasColumnType("datetime")
                     .HasColumnName("visit_time");
             });

             modelBuilder.Entity<StatisticRefHist>(entity =>
             {
                 entity.HasKey(e => e.Id).HasName("PK__statisti__3213E83FB1FE249F");

                 entity.ToTable("statistic_ref_hist");

                 entity.Property(e => e.Id)
                     .ValueGeneratedNever()
                     .HasColumnName("id");
                 entity.Property(e => e.StatisticId).HasColumnName("statistic_id");
                 entity.Property(e => e.UrlRef)
                     .HasMaxLength(500)
                     .HasColumnName("url_ref");
                 entity.Property(e => e.VisitTime)
                     .HasColumnType("datetime")
                     .HasColumnName("visit_time");
             });

             OnModelCreatingPartial(modelBuilder);
         }*/
        #endregion
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
