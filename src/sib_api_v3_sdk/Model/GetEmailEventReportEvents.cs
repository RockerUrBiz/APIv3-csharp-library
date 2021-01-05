/* 
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@sendinblue.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = sib_api_v3_sdk.Client.SwaggerDateConverter;

namespace sib_api_v3_sdk.Model
{
    /// <summary>
    /// GetEmailEventReportEvents
    /// </summary>
    [DataContract]
    public partial class GetEmailEventReportEvents :  IEquatable<GetEmailEventReportEvents>
    {
        /// <summary>
        /// Event which occurred
        /// </summary>
        /// <value>Event which occurred</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventEnum
        {
            
            /// <summary>
            /// Enum Bounces for value: bounces
            /// </summary>
            [EnumMember(Value = "bounces")]
            Bounces = 1,
            
            /// <summary>
            /// Enum HardBounces for value: hardBounces
            /// </summary>
            [EnumMember(Value = "hardBounces")]
            HardBounces = 2,
            
            /// <summary>
            /// Enum SoftBounces for value: softBounces
            /// </summary>
            [EnumMember(Value = "softBounces")]
            SoftBounces = 3,
            
            /// <summary>
            /// Enum Delivered for value: delivered
            /// </summary>
            [EnumMember(Value = "delivered")]
            Delivered = 4,
            
            /// <summary>
            /// Enum Spam for value: spam
            /// </summary>
            [EnumMember(Value = "spam")]
            Spam = 5,
            
            /// <summary>
            /// Enum Requests for value: requests
            /// </summary>
            [EnumMember(Value = "requests")]
            Requests = 6,
            
            /// <summary>
            /// Enum Opened for value: opened
            /// </summary>
            [EnumMember(Value = "opened")]
            Opened = 7,
            
            /// <summary>
            /// Enum Clicks for value: clicks
            /// </summary>
            [EnumMember(Value = "clicks")]
            Clicks = 8,
            
            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 9,
            
            /// <summary>
            /// Enum Deferred for value: deferred
            /// </summary>
            [EnumMember(Value = "deferred")]
            Deferred = 10,
            
            /// <summary>
            /// Enum Blocked for value: blocked
            /// </summary>
            [EnumMember(Value = "blocked")]
            Blocked = 11,
            
            /// <summary>
            /// Enum Unsubscribed for value: unsubscribed
            /// </summary>
            [EnumMember(Value = "unsubscribed")]
            Unsubscribed = 12,
            
            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 13
        }

        /// <summary>
        /// Event which occurred
        /// </summary>
        /// <value>Event which occurred</value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public EventEnum Event { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailEventReportEvents" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetEmailEventReportEvents() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetEmailEventReportEvents" /> class.
        /// </summary>
        /// <param name="email">Email address which generates the event (required).</param>
        /// <param name="date">UTC date-time on which the event has been generated (required).</param>
        /// <param name="subject">Subject of the event.</param>
        /// <param name="messageId">Message ID which generated the event (required).</param>
        /// <param name="_event">Event which occurred (required).</param>
        /// <param name="reason">Reason of bounce (only available if the event is hardbounce or softbounce).</param>
        /// <param name="tag">Tag of the email which generated the event.</param>
        /// <param name="ip">IP from which the user has opened the email or clicked on the link (only available if the event is opened or clicks).</param>
        /// <param name="link">The link which is sent to the user (only available if the event is requests or opened or clicks).</param>
        /// <param name="from">Sender email from which the emails are sent.</param>
        /// <param name="templateId">ID of the template (only available if the email is template based).</param>
        public GetEmailEventReportEvents(string email = default(string), DateTime? date = default(DateTime?), string subject = default(string), string messageId = default(string), EventEnum _event = default(EventEnum), string reason = default(string), string tag = default(string), string ip = default(string), string link = default(string), string from = default(string), long? templateId = default(long?))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for GetEmailEventReportEvents and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for GetEmailEventReportEvents and cannot be null");
            }
            else
            {
                this.Date = date;
            }
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new InvalidDataException("messageId is a required property for GetEmailEventReportEvents and cannot be null");
            }
            else
            {
                this.MessageId = messageId;
            }
            // to ensure "_event" is required (not null)
            if (_event == null)
            {
                throw new InvalidDataException("_event is a required property for GetEmailEventReportEvents and cannot be null");
            }
            else
            {
                this.Event = _event;
            }
            this.Subject = subject;
            this.Reason = reason;
            this.Tag = tag;
            this.Ip = ip;
            this.Link = link;
            this.From = from;
            this.TemplateId = templateId;
        }
        
        /// <summary>
        /// Email address which generates the event
        /// </summary>
        /// <value>Email address which generates the event</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// UTC date-time on which the event has been generated
        /// </summary>
        /// <value>UTC date-time on which the event has been generated</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Subject of the event
        /// </summary>
        /// <value>Subject of the event</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Message ID which generated the event
        /// </summary>
        /// <value>Message ID which generated the event</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }


        /// <summary>
        /// Reason of bounce (only available if the event is hardbounce or softbounce)
        /// </summary>
        /// <value>Reason of bounce (only available if the event is hardbounce or softbounce)</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Tag of the email which generated the event
        /// </summary>
        /// <value>Tag of the email which generated the event</value>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// IP from which the user has opened the email or clicked on the link (only available if the event is opened or clicks)
        /// </summary>
        /// <value>IP from which the user has opened the email or clicked on the link (only available if the event is opened or clicks)</value>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The link which is sent to the user (only available if the event is requests or opened or clicks)
        /// </summary>
        /// <value>The link which is sent to the user (only available if the event is requests or opened or clicks)</value>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public string Link { get; set; }

        /// <summary>
        /// Sender email from which the emails are sent
        /// </summary>
        /// <value>Sender email from which the emails are sent</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// ID of the template (only available if the email is template based)
        /// </summary>
        /// <value>ID of the template (only available if the email is template based)</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetEmailEventReportEvents {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetEmailEventReportEvents);
        }

        /// <summary>
        /// Returns true if GetEmailEventReportEvents instances are equal
        /// </summary>
        /// <param name="input">Instance of GetEmailEventReportEvents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetEmailEventReportEvents input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.Event == input.Event ||
                    (this.Event != null &&
                    this.Event.Equals(input.Event))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                return hashCode;
            }
        }
    }

}
