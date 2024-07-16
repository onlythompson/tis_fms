namespace tis_fms_domain.shared_kernel
{

    [Flags]
    public enum JournalClassification
    {
        SimpleEntry = 1 << 0,
        CompoundEntry = 1 << 1,
        OpeningEntry = 1 << 2,
        ClosingEntry = 1 << 3,
        AdjustingEntry = 1 << 4,
        ReversingEntry = 1 << 5,
        CorrectingEntry = 1 << 6,
        ReclassificationEntry = 1 << 7,
        MemorandumEntry = 1 << 8,
        ProvisionalEntry = 1 << 9,
        EstimatedEntry = 1 << 10,
        AutomatedEntry = 1 << 11,
        ManualEntry = 1 << 12,
        RecurringEntry = 1 << 13,
        RealTimeEntry = 1 << 14,
        BatchEntry = 1 << 15,
        SummaryEntry = 1 << 16,
        AllocationEntry = 1 << 17,
        ConsolidationEntry = 1 << 18,
        IntercompanyEntry = 1 << 19
    }

    /*
    // Single classification
JournalClassification classification = JournalClassification.SimpleEntry;

// Multiple classifications
JournalClassification multiClassification = JournalClassification.CompoundEntry | JournalClassification.AdjustingEntry;

// Checking if a classification is set
bool isAdjusting = multiClassification.HasFlag(JournalClassification.AdjustingEntry); // true

// Adding a classification
multiClassification |= JournalClassification.RecurringEntry;

// Removing a classification
multiClassification &= ~JournalClassification.CompoundEntry;

    */
}