namespace TransactionAPI.Models
{
    public class Transaction
    {
        public string? Id { get; set; }
        public string? DollarSignId { get; set; }
        public string? AccountNumber { get; set; }
        public int IdType { get; set; }
        public int CommentCode { get; set; }
        public int TransferCode { get; set; }
        public int AdjustmentCode { get; set; }
        public int RegECode { get; set; }
        public int RegDCheckCode { get; set; }
        public int RegDTransferCode { get; set; }
        public int VoidCode { get; set; }
        public string? SubActionCode { get; set; }
        public int SequenceNumber { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime PostDate { get; set; }
        public int PostTime { get; set; }
        public float PreviousAvailableBalance { get; set; }
        public int UserNumber { get; set; }
        public int UserOverride { get; set; }
        public int SecurityLevels { get; set; }
        public string? Description { get; set; }
        public string? ActionCode { get; set; }
        public string? SourceCode { get; set; }
        public float BalanceChange { get; set; }
        public float InterestPenalty { get; set; }
        public float NewBalance { get; set; }
        public float FeeAmount { get; set; }
        public float EscrowAmount { get; set; }
        public DateTime LastTranDate { get; set; }
        public object? MaturityLoanDueDate { get; set; }
        public string? Comment { get; set; }
        public int Branch { get; set; }
        public int ConsoleNumber { get; set; }
        public int BatchSequence { get; set; }
        public float SalesTaxAmount { get; set; }
        public DateTime ActivityDate { get; set; }
        public float BilledFeeAmount { get; set; }
        public int ProcessorUser { get; set; }
        public string? MemberBranch { get; set; }
        public int SubSourceCode { get; set; }
        public int ConfirmationSequence { get; set; }
        public string? MicrAccountNumber { get; set; }
        public string? MicrRtNumber { get; set; }
        public int Recurring { get; set; }
        public float FeeExemptCourtesyAmount { get; set; }
        public string? BalSeg001SegmentId { get; set; }
        public object? BalSeg001PmtChangeDate { get; set; }
        public object? InterestEffectiveDate { get; set; }
        public object? BalSeg001PrevFirstPmtDate { get; set; }
        public string? DraftNumber { get; set; }
        public string? TracerNumber { get; set; }
        public string? SubSourceDescription { get; set; }
        public float TransactionAmount { get; set; }
        public string? ConfirmationNumber { get; set; }

    }

}
