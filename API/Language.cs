using System.Text.Json.Serialization;

namespace API
{
    public partial class Language
    {
        [JsonPropertyName("app")]
        public App App { get; set; }

        [JsonPropertyName("server")]
        public Server Server { get; set; }

        [JsonPropertyName("land")]
        public Land Land { get; set; }
    }

    public partial class App
    {
        [JsonPropertyName("menu")]
        public AppMenu Menu { get; set; }

        [JsonPropertyName("header")]
        public AppHeader Header { get; set; }

        [JsonPropertyName("modals")]
        public Modals Modals { get; set; }

        [JsonPropertyName("pages")]
        public Pages Pages { get; set; }
    }

    public partial class AppHeader
    {
        [JsonPropertyName("sync")]
        public string Sync { get; set; }

        [JsonPropertyName("synced")]
        public string Synced { get; set; }

        [JsonPropertyName("tab-1")]
        public string Tab1 { get; set; }

        [JsonPropertyName("tab-2")]
        public string Tab2 { get; set; }

        [JsonPropertyName("exit")]
        public string Exit { get; set; }
    }

    public partial class AppMenu
    {
        [JsonPropertyName("p-1")]
        public string P1 { get; set; }

        [JsonPropertyName("p-2")]
        public string P2 { get; set; }

        [JsonPropertyName("p-3")]
        public string P3 { get; set; }

        [JsonPropertyName("p-4")]
        public string P4 { get; set; }

        [JsonPropertyName("p-5")]
        public string P5 { get; set; }

        [JsonPropertyName("p-6")]
        public string P6 { get; set; }

        [JsonPropertyName("p-7")]
        public string P7 { get; set; }

        [JsonPropertyName("p-8")]
        public string P8 { get; set; }

        [JsonPropertyName("p-9")]
        public string P9 { get; set; }

        [JsonPropertyName("p-10")]
        public string P10 { get; set; }

        [JsonPropertyName("p-11")]
        public string P11 { get; set; }

        [JsonPropertyName("p-12")]
        public string P12 { get; set; }
    }

    public partial class Modals
    {
        [JsonPropertyName("in-development-modal")]
        public InDevelopmentModal InDevelopmentModal { get; set; }

        [JsonPropertyName("add-wallet-modal")]
        public AddWalletModal AddWalletModal { get; set; }

        [JsonPropertyName("deposit-modal")]
        public DepositModal DepositModal { get; set; }

        [JsonPropertyName("withdrawal-modal")]
        public WithdrawalModal WithdrawalModal { get; set; }
    }

    public partial class AddWalletModal
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("name-msg")]
        public string NameMsg { get; set; }

        [JsonPropertyName("select-currency")]
        public string SelectCurrency { get; set; }
    }

    public partial class DepositModal
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("sender")]
        public string Sender { get; set; }

        [JsonPropertyName("receiv-address")]
        public string ReceivAddress { get; set; }

        [JsonPropertyName("generate")]
        public string Generate { get; set; }

        [JsonPropertyName("copy")]
        public string Copy { get; set; }

        [JsonPropertyName("title-2")]
        public string Title2 { get; set; }

        [JsonPropertyName("no-wallets")]
        public string NoWallets { get; set; }

        [JsonPropertyName("create-wallet")]
        public string CreateWallet { get; set; }
    }

    public partial class InDevelopmentModal
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }

    public partial class WithdrawalModal
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("sender-account")]
        public string SenderAccount { get; set; }

        [JsonPropertyName("receiver-address")]
        public string ReceiverAddress { get; set; }

        [JsonPropertyName("enter-address")]
        public string EnterAddress { get; set; }

        [JsonPropertyName("enter-receiver-address")]
        public string EnterReceiverAddress { get; set; }

        [JsonPropertyName("enter-receiver-addr")]
        public string EnterReceiverAddr { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        [JsonPropertyName("send-currency")]
        public string SendCurrency { get; set; }

        [JsonPropertyName("no-amount")]
        public string NoAmount { get; set; }

        [JsonPropertyName("deposit")]
        public string Deposit { get; set; }

        [JsonPropertyName("select-wallet")]
        public string SelectWallet { get; set; }
    }

    public partial class Pages
    {
        [JsonPropertyName("dashboard")]
        public Dashboard Dashboard { get; set; }

        [JsonPropertyName("profile")]
        public Profile Profile { get; set; }

        [JsonPropertyName("wallets")]
        public Wallets Wallets { get; set; }

        [JsonPropertyName("wallet")]
        public Wallet Wallet { get; set; }
    }

    public partial class Dashboard
    {
        [JsonPropertyName("favourite-wallet")]
        public string FavouriteWallet { get; set; }

        [JsonPropertyName("no-favourite")]
        public string NoFavourite { get; set; }

        [JsonPropertyName("transactions-last")]
        public string TransactionsLast { get; set; }

        [JsonPropertyName("transactions-last-no-data")]
        public string TransactionsLastNoData { get; set; }

        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        [JsonPropertyName("ex-rate")]
        public ExRate ExRate { get; set; }

        [JsonPropertyName("fee-paid")]
        public string FeePaid { get; set; }

        [JsonPropertyName("for-week")]
        public string ForWeek { get; set; }

        [JsonPropertyName("for-month")]
        public string ForMonth { get; set; }

        [JsonPropertyName("for-year")]
        public string ForYear { get; set; }
    }

    public partial class ExRate
    {
        [JsonPropertyName("total-balance")]
        public string TotalBalance { get; set; }

        [JsonPropertyName("balance")]
        public string Balance { get; set; }
    }

    public partial class Profile
    {
        [JsonPropertyName("no-verified")]
        public string NoVerified { get; set; }

        [JsonPropertyName("verified")]
        public string Verified { get; set; }

        [JsonPropertyName("last-transactions")]
        public string LastTransactions { get; set; }

        [JsonPropertyName("no-last-transactions")]
        public string NoLastTransactions { get; set; }

        [JsonPropertyName("security")]
        public string Security { get; set; }

        [JsonPropertyName("in-progress")]
        public string InProgress { get; set; }

        [JsonPropertyName("change-pass-form")]
        public ChangePassForm ChangePassForm { get; set; }

        [JsonPropertyName("tfa-card")]
        public TfaCard TfaCard { get; set; }
    }

    public partial class ChangePassForm
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("change")]
        public string Change { get; set; }

        [JsonPropertyName("error")]
        public string Error { get; set; }

        [JsonPropertyName("success")]
        public string Success { get; set; }

        [JsonPropertyName("old-pass-msg")]
        public string OldPassMsg { get; set; }

        [JsonPropertyName("new-pass-msg")]
        public string NewPassMsg { get; set; }

        [JsonPropertyName("min-msg")]
        public string MinMsg { get; set; }

        [JsonPropertyName("max-msg")]
        public string MaxMsg { get; set; }

        [JsonPropertyName("repeat-pass-msg")]
        public string RepeatPassMsg { get; set; }

        [JsonPropertyName("no-diff-pass")]
        public string NoDiffPass { get; set; }
    }

    public partial class TfaCard
    {
        [JsonPropertyName("tfa-connect")]
        public TfaConnect TfaConnect { get; set; }

        [JsonPropertyName("tfa-delete")]
        public TfaDelete TfaDelete { get; set; }
    }

    public partial class TfaConnect
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("connect")]
        public string Connect { get; set; }

        [JsonPropertyName("secret")]
        public string Secret { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("enter-code")]
        public string EnterCode { get; set; }
    }

    public partial class TfaDelete
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("auth-code-enter")]
        public string AuthCodeEnter { get; set; }

        [JsonPropertyName("btn")]
        public string Btn { get; set; }
    }

    public partial class Wallet
    {
        [JsonPropertyName("receive")]
        public string Receive { get; set; }

        [JsonPropertyName("send")]
        public string Send { get; set; }

        [JsonPropertyName("transaction-table")]
        public Table TransactionTable { get; set; }

        [JsonPropertyName("chart")]
        public Chart Chart { get; set; }
    }

    public partial class Chart
    {
        [JsonPropertyName("w")]
        public string W { get; set; }

        [JsonPropertyName("m")]
        public string M { get; set; }

        [JsonPropertyName("y")]
        public string Y { get; set; }
    }

    public partial class Table
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("tx-hash")]
        public string TxHash { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        [JsonPropertyName("fee")]
        public string Fee { get; set; }

        [JsonPropertyName("created-at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("no-data")]
        public string NoData { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }

    public partial class Wallets
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("sub-title")]
        public string SubTitle { get; set; }

        [JsonPropertyName("favourite-only")]
        public string FavouriteOnly { get; set; }

        [JsonPropertyName("show-empty")]
        public string ShowEmpty { get; set; }

        [JsonPropertyName("account-table")]
        public AccountTable AccountTable { get; set; }

        [JsonPropertyName("to-favourite")]
        public string ToFavourite { get; set; }

        [JsonPropertyName("no-data")]
        public string NoData { get; set; }

        [JsonPropertyName("add-wallet")]
        public string AddWallet { get; set; }

        [JsonPropertyName("last-deposits-table")]
        public Table LastDepositsTable { get; set; }

        [JsonPropertyName("last-withdrawals-table")]
        public Table LastWithdrawalsTable { get; set; }
    }

    public partial class AccountTable
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("current")]
        public string Current { get; set; }

        [JsonPropertyName("created-at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("receive")]
        public string Receive { get; set; }

        [JsonPropertyName("send")]
        public string Send { get; set; }
    }

    public partial class Land
    {
        [JsonPropertyName("home")]
        public Home Home { get; set; }

        [JsonPropertyName("header")]
        public LandHeader Header { get; set; }

        [JsonPropertyName("login")]
        public Login Login { get; set; }

        [JsonPropertyName("register")]
        public Register Register { get; set; }

        [JsonPropertyName("footer")]
        public Footer Footer { get; set; }
    }

    public partial class Footer
    {
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        [JsonPropertyName("quick-rec")]
        public string QuickRec { get; set; }

        [JsonPropertyName("important-mail")]
        public string ImportantMail { get; set; }

        [JsonPropertyName("menu")]
        public FooterMenu Menu { get; set; }

        [JsonPropertyName("descr-2")]
        public string Descr2 { get; set; }

        [JsonPropertyName("enter-email")]
        public string EnterEmail { get; set; }

        [JsonPropertyName("follow")]
        public string Follow { get; set; }
    }

    public partial class FooterMenu
    {
        [JsonPropertyName("p-1")]
        public string P1 { get; set; }

        [JsonPropertyName("p-2")]
        public string P2 { get; set; }
    }

    public partial class LandHeader
    {
        [JsonPropertyName("menu")]
        public AppMenu Menu { get; set; }
    }

    public partial class Home
    {
        [JsonPropertyName("secure-wallet")]
        public string SecureWallet { get; set; }

        [JsonPropertyName("study-wallet")]
        public string StudyWallet { get; set; }

        [JsonPropertyName("connect-wallet")]
        public string ConnectWallet { get; set; }

        [JsonPropertyName("enter")]
        public string Enter { get; set; }

        [JsonPropertyName("isa-using")]
        public string IsaUsing { get; set; }

        [JsonPropertyName("support-currency")]
        public string SupportCurrency { get; set; }

        [JsonPropertyName("and-more")]
        public string AndMore { get; set; }

        [JsonPropertyName("networks")]
        public string Networks { get; set; }

        [JsonPropertyName("multifunct")]
        public string Multifunct { get; set; }

        [JsonPropertyName("sarnado-wallet")]
        public string SarnadoWallet { get; set; }

        [JsonPropertyName("in-your-home")]
        public string InYourHome { get; set; }

        [JsonPropertyName("work-block-1")]
        public TockenBlock1 WorkBlock1 { get; set; }

        [JsonPropertyName("work-block-2")]
        public TockenBlock1 WorkBlock2 { get; set; }

        [JsonPropertyName("work-block-3")]
        public TockenBlock1 WorkBlock3 { get; set; }

        [JsonPropertyName("work-block-4")]
        public TockenBlock1 WorkBlock4 { get; set; }

        [JsonPropertyName("work-block-5")]
        public TockenBlock1 WorkBlock5 { get; set; }

        [JsonPropertyName("tocken-block-1")]
        public TockenBlock1 TockenBlock1 { get; set; }

        [JsonPropertyName("tocken-block-2")]
        public TockenBlock2 TockenBlock2 { get; set; }

        [JsonPropertyName("tocken-block-3")]
        public TockenBlock3 TockenBlock3 { get; set; }

        [JsonPropertyName("mobile-app")]
        public string MobileApp { get; set; }

        [JsonPropertyName("mobile-desc")]
        public string MobileDesc { get; set; }

        [JsonPropertyName("mobile-desc-2")]
        public string MobileDesc2 { get; set; }

        [JsonPropertyName("text-secure")]
        public string TextSecure { get; set; }

        [JsonPropertyName("desc-secure")]
        public string DescSecure { get; set; }

        [JsonPropertyName("email-verify")]
        public string EmailVerify { get; set; }

        [JsonPropertyName("sms-verify")]
        public string SmsVerify { get; set; }

        [JsonPropertyName("yubi-key")]
        public string YubiKey { get; set; }

        [JsonPropertyName("lets-start")]
        public string LetsStart { get; set; }

        [JsonPropertyName("back-phrase")]
        public string BackPhrase { get; set; }

        [JsonPropertyName("service-work")]
        public string ServiceWork { get; set; }

        [JsonPropertyName("service-work-text")]
        public string ServiceWorkText { get; set; }

        [JsonPropertyName("road-map")]
        public RoadMap RoadMap { get; set; }

        [JsonPropertyName("our-team")]
        public string OurTeam { get; set; }

        [JsonPropertyName("our-team-desc")]
        public string OurTeamDesc { get; set; }

        [JsonPropertyName("about")]
        public string About { get; set; }

        [JsonPropertyName("team-1")]
        public Team Team1 { get; set; }

        [JsonPropertyName("team-2")]
        public Team Team2 { get; set; }

        [JsonPropertyName("team-3")]
        public Team Team3 { get; set; }

        [JsonPropertyName("team-4")]
        public Team Team4 { get; set; }

        [JsonPropertyName("support")]
        public Support Support { get; set; }

        [JsonPropertyName("faq")]
        public string Faq { get; set; }

        [JsonPropertyName("faq-desc")]
        public string FaqDesc { get; set; }

        [JsonPropertyName("main")]
        public string Main { get; set; }

        [JsonPropertyName("cran")]
        public string Cran { get; set; }

        [JsonPropertyName("security")]
        public string Security { get; set; }

        [JsonPropertyName("free-service")]
        public string FreeService { get; set; }

        [JsonPropertyName("free-service-descr")]
        public string FreeServiceDescr { get; set; }

        [JsonPropertyName("no-verify")]
        public string NoVerify { get; set; }

        [JsonPropertyName("no-verify-desc")]
        public string NoVerifyDesc { get; set; }

        [JsonPropertyName("merch-payment")]
        public string MerchPayment { get; set; }

        [JsonPropertyName("merch-payment-answ")]
        public string MerchPaymentAnsw { get; set; }

        [JsonPropertyName("crypto-buy")]
        public string CryptoBuy { get; set; }

        [JsonPropertyName("crypto-buy-answ")]
        public string CryptoBuyAnsw { get; set; }

        [JsonPropertyName("get-crypto")]
        public string GetCrypto { get; set; }

        [JsonPropertyName("get-crypto-answ")]
        public string GetCryptoAnsw { get; set; }

        [JsonPropertyName("tx-id")]
        public string TxId { get; set; }

        [JsonPropertyName("tx-id-answ")]
        public string TxIdAnsw { get; set; }

        [JsonPropertyName("btc-lost")]
        public string BtcLost { get; set; }

        [JsonPropertyName("btc-lost-answ")]
        public string BtcLostAnsw { get; set; }

        [JsonPropertyName("invest")]
        public string Invest { get; set; }

        [JsonPropertyName("invest-answ")]
        public string InvestAnsw { get; set; }

        [JsonPropertyName("what-isa")]
        public string WhatIsa { get; set; }

        [JsonPropertyName("what-isa-answ")]
        public string WhatIsaAnsw { get; set; }

        [JsonPropertyName("token-cran-why")]
        public string TokenCranWhy { get; set; }

        [JsonPropertyName("token-cran-why-answ")]
        public string TokenCranWhyAnsw { get; set; }

        [JsonPropertyName("where-tokens")]
        public string WhereTokens { get; set; }

        [JsonPropertyName("where-tokens-answ")]
        public string WhereTokensAnsw { get; set; }

        [JsonPropertyName("can-get-isa")]
        public string CanGetIsa { get; set; }

        [JsonPropertyName("can-get-isa-answ")]
        public string CanGetIsaAnsw { get; set; }

        [JsonPropertyName("where-send")]
        public string WhereSend { get; set; }

        [JsonPropertyName("where-send-answ")]
        public string WhereSendAnsw { get; set; }

        [JsonPropertyName("trades-token")]
        public string TradesToken { get; set; }

        [JsonPropertyName("trades-token-isa")]
        public string TradesTokenIsa { get; set; }

        [JsonPropertyName("depon-period")]
        public string DeponPeriod { get; set; }

        [JsonPropertyName("depon-period-answ")]
        public string DeponPeriodAnsw { get; set; }

        [JsonPropertyName("token-emission")]
        public string TokenEmission { get; set; }

        [JsonPropertyName("token-emission-answ")]
        public string TokenEmissionAnsw { get; set; }

        [JsonPropertyName("lost-comp")]
        public string LostComp { get; set; }

        [JsonPropertyName("lost-comp-answ")]
        public string LostCompAnsw { get; set; }

        [JsonPropertyName("lost-pass")]
        public string LostPass { get; set; }

        [JsonPropertyName("lost-pass-answ")]
        public string LostPassAnsw { get; set; }

        [JsonPropertyName("tfa-sup")]
        public string TfaSup { get; set; }

        [JsonPropertyName("tfa-sup-answ")]
        public string TfaSupAnsw { get; set; }

        [JsonPropertyName("is-ver")]
        public string IsVer { get; set; }

        [JsonPropertyName("is-ver-answ")]
        public string IsVerAnsw { get; set; }

        [JsonPropertyName("secure-pass")]
        public string SecurePass { get; set; }

        [JsonPropertyName("secure-pass-answ")]
        public string SecurePassAnsw { get; set; }

        [JsonPropertyName("illegal-crypto")]
        public string IllegalCrypto { get; set; }

        [JsonPropertyName("illegal-crypto-answ")]
        public string IllegalCryptoAnsw { get; set; }

        [JsonPropertyName("regulate-crypto")]
        public string RegulateCrypto { get; set; }

        [JsonPropertyName("regulate-crypto-answ")]
        public string RegulateCryptoAnsw { get; set; }

        [JsonPropertyName("tax-crypto")]
        public string TaxCrypto { get; set; }

        [JsonPropertyName("tax-crypto-answ")]
        public string TaxCryptoAnsw { get; set; }

        [JsonPropertyName("partners")]
        public string Partners { get; set; }

        [JsonPropertyName("connects")]
        public string Connects { get; set; }

        [JsonPropertyName("email-contact")]
        public string EmailContact { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("address-real")]
        public string AddressReal { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("email-id")]
        public string EmailId { get; set; }

        [JsonPropertyName("follow-us")]
        public string FollowUs { get; set; }

        [JsonPropertyName("message-us")]
        public string MessageUs { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("you-mail")]
        public string YouMail { get; set; }

        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [JsonPropertyName("you-message")]
        public string YouMessage { get; set; }

        [JsonPropertyName("send")]
        public string Send { get; set; }

        [JsonPropertyName("submit-message")]
        public string SubmitMessage { get; set; }

        [JsonPropertyName("contact-form")]
        public ContactForm ContactForm { get; set; }
    }

    public partial class ContactForm
    {
        [JsonPropertyName("name-imp")]
        public string NameImp { get; set; }

        [JsonPropertyName("email-imp")]
        public string EmailImp { get; set; }

        [JsonPropertyName("invalid-email")]
        public string InvalidEmail { get; set; }

        [JsonPropertyName("max-symb")]
        public string MaxSymb { get; set; }

        [JsonPropertyName("text-imp")]
        public string TextImp { get; set; }

        [JsonPropertyName("max-250")]
        public string Max250 { get; set; }
    }

    public partial class RoadMap
    {
        [JsonPropertyName("date-1")]
        public Date Date1 { get; set; }

        [JsonPropertyName("date-2")]
        public Date Date2 { get; set; }

        [JsonPropertyName("date-3")]
        public Date Date3 { get; set; }

        [JsonPropertyName("date-4")]
        public Date Date4 { get; set; }

        [JsonPropertyName("date-5")]
        public Date Date5 { get; set; }

        [JsonPropertyName("date-6")]
        public Date Date6 { get; set; }

        [JsonPropertyName("date-7")]
        public Date Date7 { get; set; }

        [JsonPropertyName("date-8")]
        public Date Date8 { get; set; }

        [JsonPropertyName("date-9")]
        public Date Date9 { get; set; }

        [JsonPropertyName("date-10")]
        public Date Date10 { get; set; }
    }

    public partial class Date
    {
        [JsonPropertyName("dname")]
        public string Dname { get; set; }

        [JsonPropertyName("desc")]
        public string Desc { get; set; }
    }

    public partial class Support
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("team-1")]
        public Team Team1 { get; set; }

        [JsonPropertyName("team-2")]
        public Team Team2 { get; set; }

        [JsonPropertyName("team-3")]
        public Team Team3 { get; set; }

        [JsonPropertyName("team-4")]
        public Team Team4 { get; set; }
    }

    public partial class Team
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("descr")]
        public string Descr { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("port-1")]
        public string Port1 { get; set; }

        [JsonPropertyName("port-2")]
        public string Port2 { get; set; }

        [JsonPropertyName("port-3")]
        public string Port3 { get; set; }
    }

    public partial class TockenBlock1
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public partial class TockenBlock2
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("start-gift")]
        public string StartGift { get; set; }

        [JsonPropertyName("end-gift")]
        public string EndGift { get; set; }

        [JsonPropertyName("current-cran")]
        public string CurrentCran { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("ex-rate")]
        public string ExRate { get; set; }

        [JsonPropertyName("wallet")]
        public string Wallet { get; set; }
    }

    public partial class TockenBlock3
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("open-wallet")]
        public string OpenWallet { get; set; }

        [JsonPropertyName("current-rate")]
        public string CurrentRate { get; set; }

        [JsonPropertyName("volume")]
        public string Volume { get; set; }

        [JsonPropertyName("acceptable-currency")]
        public string AcceptableCurrency { get; set; }
    }

    public partial class Login
    {
        [JsonPropertyName("enter")]
        public string Enter { get; set; }

        [JsonPropertyName("enter-2")]
        public string Enter2 { get; set; }

        [JsonPropertyName("hello")]
        public string Hello { get; set; }

        [JsonPropertyName("enter-to-acc")]
        public string EnterToAcc { get; set; }

        [JsonPropertyName("enter-email")]
        public string EnterEmail { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("enter-pass")]
        public string EnterPass { get; set; }

        [JsonPropertyName("tfa-code")]
        public string TfaCode { get; set; }

        [JsonPropertyName("tfa-code-2")]
        public string TfaCode2 { get; set; }

        [JsonPropertyName("enter-3")]
        public string Enter3 { get; set; }

        [JsonPropertyName("fogget-password")]
        public string FoggetPassword { get; set; }

        [JsonPropertyName("noaccount")]
        public string Noaccount { get; set; }

        [JsonPropertyName("registr")]
        public string Registr { get; set; }

        [JsonPropertyName("loginormail")]
        public string Loginormail { get; set; }
    }

    public partial class Register
    {
        [JsonPropertyName("reg")]
        public string Reg { get; set; }

        [JsonPropertyName("home")]
        public string Home { get; set; }

        [JsonPropertyName("reg-2")]
        public string Reg2 { get; set; }

        [JsonPropertyName("create-account")]
        public string CreateAccount { get; set; }

        [JsonPropertyName("enter-username")]
        public string EnterUsername { get; set; }

        [JsonPropertyName("enter-email")]
        public string EnterEmail { get; set; }

        [JsonPropertyName("enter-name")]
        public string EnterName { get; set; }

        [JsonPropertyName("enter-pass")]
        public string EnterPass { get; set; }

        [JsonPropertyName("min-smbl")]
        public string MinSmbl { get; set; }

        [JsonPropertyName("max-smbl")]
        public string MaxSmbl { get; set; }

        [JsonPropertyName("accept")]
        public string Accept { get; set; }

        [JsonPropertyName("reg-3")]
        public string Reg3 { get; set; }

        [JsonPropertyName("enter")]
        public string Enter { get; set; }

        [JsonPropertyName("signup")]
        public string Signup { get; set; }

        [JsonPropertyName("already-acc")]
        public string AlreadyAcc { get; set; }
    }

    public partial class Server
    {
        [JsonPropertyName("errors")]
        public Errors Errors { get; set; }
    }

    public partial class Errors
    {
        [JsonPropertyName("default-error")]
        public string DefaultError { get; set; }

        [JsonPropertyName("wrong-name-or-password")]
        public string WrongNameOrPassword { get; set; }

        [JsonPropertyName("no-crypto")]
        public string NoCrypto { get; set; }

        [JsonPropertyName("min-amount")]
        public string MinAmount { get; set; }

        [JsonPropertyName("imposible-tx")]
        public string ImposibleTx { get; set; }

        [JsonPropertyName("error-tfa")]
        public string ErrorTfa { get; set; }

        [JsonPropertyName("email-incorrect")]
        public string EmailIncorrect { get; set; }

        [JsonPropertyName("login-already-exist")]
        public string LoginAlreadyExist { get; set; }

        [JsonPropertyName("email-already-exists")]
        public string EmailAlreadyExists { get; set; }

        [JsonPropertyName("min-pass")]
        public string MinPass { get; set; }

        [JsonPropertyName("empty-email")]
        public string EmptyEmail { get; set; }

        [JsonPropertyName("user-not-found")]
        public string UserNotFound { get; set; }

        [JsonPropertyName("reg-error")]
        public string RegError { get; set; }

        [JsonPropertyName("error-code")]
        public string ErrorCode { get; set; }

        [JsonPropertyName("error-on-tfa")]
        public string ErrorOnTfa { get; set; }

        [JsonPropertyName("no-name-crypto")]
        public string NoNameCrypto { get; set; }

        [JsonPropertyName("account-not-found")]
        public string AccountNotFound { get; set; }

        [JsonPropertyName("only-one-currencie")]
        public string OnlyOneCurrencie { get; set; }

        [JsonPropertyName("once-eth")]
        public string OnceEth { get; set; }

        [JsonPropertyName("invalid-sign")]
        public string InvalidSign { get; set; }

        [JsonPropertyName("field-empty")]
        public string FieldEmpty { get; set; }

        [JsonPropertyName("account-already-exists")]
        public string AccountAlreadyExists { get; set; }

        [JsonPropertyName("account-not-exists")]
        public string AccountNotExists { get; set; }

        [JsonPropertyName("error-create-account")]
        public string ErrorCreateAccount { get; set; }

        [JsonPropertyName("add-account-merch")]
        public string AddAccountMerch { get; set; }
    }

    //public partial class Language
    //{
    //    public static Language FromJson(string json) => JsonConvert.DeserializeObject<Language>(json, Converter.Settings);
    //}

    //public static class Serialize
    //{
    //    public static string ToJson(this Language self) => JsonConvert.SerializeObject(self, Converter.Settings);
    //}

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //        {
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}
}
