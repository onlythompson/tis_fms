namespace tis_fms_domain.shared_kernel
{

    /// <summary>
    /// Defines the types of journals used in accounting and financial transactions.
    /// Each member of this enumeration represents a specific type of journal entry that is used to categorize and record financial transactions in an accounting system.
    /// </summary>
    public enum JournalDefinition
    {
        /// <summary>
        /// Represents a journal for recording purchases.
        /// </summary>
        PURCHASE = 1,

        /// <summary>
        /// Represents a journal for recording sales transactions.
        /// </summary>
        SALES = 2,

        /// <summary>
        /// Represents a journal for recording cash receipts.
        /// </summary>
        CASH_RECEIPTS = 3,

        /// <summary>
        /// Represents a journal for recording cash disbursements.
        /// </summary>
        CASH_DISBURSEMENTS = 4,

        /// <summary>
        /// Represents a general-purpose journal for transactions that do not fit into other categories.
        /// </summary>
        GENERAL = 5,

        /// <summary>
        /// Represents a journal for recording payroll transactions.
        /// </summary>
        PAYROLL = 6,

        /// <summary>
        /// Represents a journal for recording transactions related to fixed assets.
        /// </summary>
        FIXED_ASSET = 7,

        /// <summary>
        /// Represents a journal for recording inventory transactions.
        /// </summary>
        INVENTORY = 8,

        /// <summary>
        /// Represents a journal for recording transactions related to accounts receivable.
        /// </summary>
        ACCOUNTS_RECEIVABLE = 9,

        /// <summary>
        /// Represents a journal for recording transactions related to accounts payable.
        /// </summary>
        ACCOUNTS_PAYABLE = 10,

        /// <summary>
        /// Represents a journal for recording bank reconciliation adjustments.
        /// </summary>
        BANK_RECONCILIATION = 11,

        /// <summary>
        /// Represents a journal for recording adjusting entries.
        /// </summary>
        ADJUSTING = 12,

        /// <summary>
        /// Represents a journal for recording closing entries at the end of an accounting period.
        /// </summary>
        CLOSING = 13,

        /// <summary>
        /// Represents a journal for recording reversing entries, typically at the beginning of a new accounting period.
        /// </summary>
        REVERSING = 14,

        /// <summary>
        /// Represents a journal for recording recurring entries.
        /// </summary>
        RECURRING = 15,

        /// <summary>
        /// Represents a journal for recording accruals.
        /// </summary>
        ACCRUAL = 16,

        /// <summary>
        /// Represents a journal for recording deferrals.
        /// </summary>
        DEFERRAL = 17,

        /// <summary>
        /// Represents a journal for recording depreciation of assets.
        /// </summary>
        DEPRECIATION = 18,

        /// <summary>
        /// Represents a journal for recording amortization of intangible assets.
        /// </summary>
        AMORTIZATION = 19,

        /// <summary>
        /// Represents a journal for recording prepayments.
        /// </summary>
        PREPAYMENT = 20,

        /// <summary>
        /// Represents a journal for recording intercompany transactions.
        /// </summary>
        INTERCOMPANY = 21,

        /// <summary>
        /// Represents a journal for recording revaluation adjustments.
        /// </summary>
        REVALUATION = 22,

        /// <summary>
        /// Represents a journal for recording cost allocation.
        /// </summary>
        COST_ALLOCATION = 23,

        /// <summary>
        /// Represents a journal for recording transfer pricing adjustments.
        /// </summary>
        TRANSFER_PRICING = 24,

        /// <summary>
        /// Represents a journal for recording investment transactions.
        /// </summary>
        INVESTMENT = 25,

        /// <summary>
        /// Represents a journal for recording loan transactions.
        /// </summary>
        LOAN = 26,

        /// <summary>
        /// Represents a journal for recording tax-related transactions.
        /// </summary>
        TAX = 27,

        /// <summary>
        /// Represents a journal for recording consolidation entries.
        /// </summary>
        CONSOLIDATION = 28,

        /// <summary>
        /// Represents a journal for recording project accounting transactions.
        /// </summary>
        PROJECT_ACCOUNTING = 29,

        /// <summary>
        /// Represents a journal for recording manufacturing cost transactions.
        /// </summary>
        MANUFACTURING_COST = 30
    }
}