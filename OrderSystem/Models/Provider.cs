namespace OrderSystem.Entities
{
    public class Provider
    {
        public string LegalEntityIdentifier { get; set; }
        public string CorporateName { get; set; }
        public string State { get; set; }
        public string EmailContact { get; set; }
        public string NameContact { get; set; }

        public Provider() { }

        public Provider(string legalEntityIdentifier, string corporateName, string state, string emailContact, string nameContact)
        {
            LegalEntityIdentifier = legalEntityIdentifier;
            CorporateName = corporateName;
            State = state;
            EmailContact = emailContact;
            NameContact = nameContact;
        }
    }
}
