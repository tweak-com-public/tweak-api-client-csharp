/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.6
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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

namespace TweakApi.Model
{
    /// <summary>
    /// QTask
    /// </summary>
    [DataContract]
    public partial class QTask :  IEquatable<QTask>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QTask" /> class.
        /// </summary>
        /// <param name="Chain">Chain.</param>
        /// <param name="Events">Events.</param>
        /// <param name="Status">Status (default to &quot;queued&quot;).</param>
        /// <param name="_Params">_Params.</param>
        /// <param name="Queue">Queue (default to &quot;default&quot;).</param>
        /// <param name="Count">Count (default to 0.0).</param>
        /// <param name="Attempts">Attempts (default to 5.0).</param>
        /// <param name="Remaining">Remaining (default to 5.0).</param>
        /// <param name="Delay">Delay.</param>
        /// <param name="Priority">Priority (default to 0.0).</param>
        /// <param name="Ended">Ended.</param>
        /// <param name="Enqueued">Enqueued.</param>
        /// <param name="Result">Result.</param>
        /// <param name="Error">Error.</param>
        /// <param name="Stack">Stack.</param>
        /// <param name="Id">Id.</param>
        /// <param name="ItemId">ItemId.</param>
        /// <param name="ItemType">ItemType.</param>
        public QTask(List<string> Chain = null, List<Object> Events = null, string Status = null, Object _Params = null, string Queue = null, double? Count = null, double? Attempts = null, double? Remaining = null, DateTime? Delay = null, double? Priority = null, DateTime? Ended = null, DateTime? Enqueued = null, Object Result = null, Object Error = null, Object Stack = null, ObjectID Id = null, ObjectID ItemId = null, string ItemType = null)
        {
            this.Chain = Chain;
            this.Events = Events;
            // use default value if no "Status" provided
            if (Status == null)
            {
                this.Status = "queued";
            }
            else
            {
                this.Status = Status;
            }
            this._Params = _Params;
            // use default value if no "Queue" provided
            if (Queue == null)
            {
                this.Queue = "default";
            }
            else
            {
                this.Queue = Queue;
            }
            // use default value if no "Count" provided
            if (Count == null)
            {
                this.Count = 0.0;
            }
            else
            {
                this.Count = Count;
            }
            // use default value if no "Attempts" provided
            if (Attempts == null)
            {
                this.Attempts = 5.0;
            }
            else
            {
                this.Attempts = Attempts;
            }
            // use default value if no "Remaining" provided
            if (Remaining == null)
            {
                this.Remaining = 5.0;
            }
            else
            {
                this.Remaining = Remaining;
            }
            this.Delay = Delay;
            // use default value if no "Priority" provided
            if (Priority == null)
            {
                this.Priority = 0.0;
            }
            else
            {
                this.Priority = Priority;
            }
            this.Ended = Ended;
            this.Enqueued = Enqueued;
            this.Result = Result;
            this.Error = Error;
            this.Stack = Stack;
            this.Id = Id;
            this.ItemId = ItemId;
            this.ItemType = ItemType;
        }
        
        /// <summary>
        /// Gets or Sets Chain
        /// </summary>
        [DataMember(Name="chain", EmitDefaultValue=false)]
        public List<string> Chain { get; set; }
        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<Object> Events { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets _Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public Object _Params { get; set; }
        /// <summary>
        /// Gets or Sets Queue
        /// </summary>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public string Queue { get; set; }
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public double? Count { get; set; }
        /// <summary>
        /// Gets or Sets Attempts
        /// </summary>
        [DataMember(Name="attempts", EmitDefaultValue=false)]
        public double? Attempts { get; set; }
        /// <summary>
        /// Gets or Sets Remaining
        /// </summary>
        [DataMember(Name="remaining", EmitDefaultValue=false)]
        public double? Remaining { get; set; }
        /// <summary>
        /// Gets or Sets Delay
        /// </summary>
        [DataMember(Name="delay", EmitDefaultValue=false)]
        public DateTime? Delay { get; set; }
        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public double? Priority { get; set; }
        /// <summary>
        /// Gets or Sets Ended
        /// </summary>
        [DataMember(Name="ended", EmitDefaultValue=false)]
        public DateTime? Ended { get; set; }
        /// <summary>
        /// Gets or Sets Enqueued
        /// </summary>
        [DataMember(Name="enqueued", EmitDefaultValue=false)]
        public DateTime? Enqueued { get; set; }
        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public Object Result { get; set; }
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public Object Error { get; set; }
        /// <summary>
        /// Gets or Sets Stack
        /// </summary>
        [DataMember(Name="stack", EmitDefaultValue=false)]
        public Object Stack { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public ObjectID Id { get; set; }
        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="itemId", EmitDefaultValue=false)]
        public ObjectID ItemId { get; set; }
        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        [DataMember(Name="itemType", EmitDefaultValue=false)]
        public string ItemType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QTask {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Attempts: ").Append(Attempts).Append("\n");
            sb.Append("  Remaining: ").Append(Remaining).Append("\n");
            sb.Append("  Delay: ").Append(Delay).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Ended: ").Append(Ended).Append("\n");
            sb.Append("  Enqueued: ").Append(Enqueued).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Stack: ").Append(Stack).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as QTask);
        }

        /// <summary>
        /// Returns true if QTask instances are equal
        /// </summary>
        /// <param name="other">Instance of QTask to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QTask other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Chain == other.Chain ||
                    this.Chain != null &&
                    this.Chain.SequenceEqual(other.Chain)
                ) && 
                (
                    this.Events == other.Events ||
                    this.Events != null &&
                    this.Events.SequenceEqual(other.Events)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this._Params == other._Params ||
                    this._Params != null &&
                    this._Params.Equals(other._Params)
                ) && 
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Attempts == other.Attempts ||
                    this.Attempts != null &&
                    this.Attempts.Equals(other.Attempts)
                ) && 
                (
                    this.Remaining == other.Remaining ||
                    this.Remaining != null &&
                    this.Remaining.Equals(other.Remaining)
                ) && 
                (
                    this.Delay == other.Delay ||
                    this.Delay != null &&
                    this.Delay.Equals(other.Delay)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this.Ended == other.Ended ||
                    this.Ended != null &&
                    this.Ended.Equals(other.Ended)
                ) && 
                (
                    this.Enqueued == other.Enqueued ||
                    this.Enqueued != null &&
                    this.Enqueued.Equals(other.Enqueued)
                ) && 
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) && 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) && 
                (
                    this.Stack == other.Stack ||
                    this.Stack != null &&
                    this.Stack.Equals(other.Stack)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
                ) && 
                (
                    this.ItemType == other.ItemType ||
                    this.ItemType != null &&
                    this.ItemType.Equals(other.ItemType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Chain != null)
                    hash = hash * 59 + this.Chain.GetHashCode();
                if (this.Events != null)
                    hash = hash * 59 + this.Events.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this._Params != null)
                    hash = hash * 59 + this._Params.GetHashCode();
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Attempts != null)
                    hash = hash * 59 + this.Attempts.GetHashCode();
                if (this.Remaining != null)
                    hash = hash * 59 + this.Remaining.GetHashCode();
                if (this.Delay != null)
                    hash = hash * 59 + this.Delay.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.Ended != null)
                    hash = hash * 59 + this.Ended.GetHashCode();
                if (this.Enqueued != null)
                    hash = hash * 59 + this.Enqueued.GetHashCode();
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                if (this.Stack != null)
                    hash = hash * 59 + this.Stack.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                if (this.ItemType != null)
                    hash = hash * 59 + this.ItemType.GetHashCode();
                return hash;
            }
        }
    }

}
