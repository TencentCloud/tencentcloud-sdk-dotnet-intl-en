/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TelCdrInfo : AbstractModel
    {
        
        /// <summary>
        /// Caller number.
        /// </summary>
        [JsonProperty("Caller")]
        public string Caller{ get; set; }

        /// <summary>
        /// Called number.
        /// </summary>
        [JsonProperty("Callee")]
        public string Callee{ get; set; }

        /// <summary>
        /// Call initiation timestamp, unix timestamp.
        /// </summary>
        [JsonProperty("Time")]
        public long? Time{ get; set; }

        /// <summary>
        /// Call direction: 0 - inbound, 1 - outbound.
        /// </summary>
        [JsonProperty("Direction")]
        public long? Direction{ get; set; }

        /// <summary>
        /// Call Type: 1. Voice outbound call 2. Voice Inbound call 3. Audio Inbound 5 Predictive Dialing Call 6. Internal Call between Staff
        /// </summary>
        [JsonProperty("CallType")]
        public long? CallType{ get; set; }

        /// <summary>
        /// Call duration.
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// Recording information.
        /// </summary>
        [JsonProperty("RecordURL")]
        public string RecordURL{ get; set; }

        /// <summary>
        /// Recording id.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// Agent information.
        /// </summary>
        [JsonProperty("SeatUser")]
        public SeatUserInfo SeatUser{ get; set; }

        /// <summary>
        /// EndStatus corresponds one-to-one with EndStatusString. the specific enumeration is as follows:.
        /// 
        /// **Scenario**	EndStatus	EndStatusString	Status description.
        /// 
        /// Incoming & outgoing calls. 1. ok. normal call.
        /// 
        /// IVR period user give up.
        /// 
        /// **User give up while in queue**.
        /// 
        /// Inbound call 104 ringingGiveUp. specifies the user gives up during ringing.
        /// 
        /// Inbound call 105. specifies no agent online.
        /// 
        /// Inbound call notWorkTime **off hours**.   
        /// 
        /// IVR ends automatically (no manual intervention).
        /// 
        /// Inbound call. 100. blocklist (system side).
        /// 
        /// restrictedCallee. specifies the global outbound call risk number interception (system side).
        /// 
        /// Outbound call 109 tooManyRequest **outbound call frequency control interception (system side)**.
        /// 
        /// Outbound call 110 restrictedArea **block outgoing calls by region (system side)**.
        /// 
        /// restrictedTime. specifies the outbound call interception period on the system side.
        ///                          
        /// 202 notAnswer **callee unanswered**.
        /// 
        /// Outbound call 203 userReject **callee reject hangup**.
        /// 
        /// Power off. **callee powered off**.
        /// 
        /// 205            numberNotExist	**callee nonexistent number**.
        /// 
        /// Busy. specifies the callee is busy.
        /// 
        /// Outbound call 207 outOfCredit **callee in arrears**.
        /// 
        /// 208 operatorError indicates operator channel exception.
        /// 
        /// Outgoing call caller cancellation.
        /// 
        /// Outgoing call	        210	           notInService	**callee out of service area**.
        /// 
        /// Phone call in/out 211 clientError **client error**.
        /// 
        /// Outgoing call 212 carrierBlocked **carrier blocklist**.
        /// 
        /// Note: call reminder.
        /// 
        /// Outbound call 215 numberInvalid **called number is invalid**.
        /// 
        /// Outbound call 216 callRestricted. note: call restricted.
        /// 
        /// Callee restricted by blocklist.
        /// 
        /// Outbound call 218 areaRestricted. **callee area restricted**.
        /// 
        /// Prompt call forwarding.
        /// 
        /// Caller cancellation during ringing.
        /// 
        /// Caller cancel without ring.
        /// 
        /// Audio dial-in 501 call conflict **VoIP user call termination**.
        /// 
        /// VoIP user client timeout.
        /// 
        /// Audio dial-in 503 VoIP user client error.
        /// 
        /// Chinese description (https://www.tencentcloud.com/zh/document/product/1229/71847).
        /// 
        /// English description (https://www.tencentcloud.com/document/product/1229/71847?lang=en).
        /// </summary>
        [JsonProperty("EndStatus")]
        public long? EndStatus{ get; set; }

        /// <summary>
        /// Skill group name.
        /// </summary>
        [JsonProperty("SkillGroup")]
        public string SkillGroup{ get; set; }

        /// <summary>
        /// Caller'S location.
        /// </summary>
        [JsonProperty("CallerLocation")]
        public string CallerLocation{ get; set; }

        /// <summary>
        /// Time spent in ivr stage.
        /// </summary>
        [JsonProperty("IVRDuration")]
        public long? IVRDuration{ get; set; }

        /// <summary>
        /// Ring timestamp. unix second-level timestamp.
        /// </summary>
        [JsonProperty("RingTimestamp")]
        public long? RingTimestamp{ get; set; }

        /// <summary>
        /// Answer timestamp. unix second-level timestamp.
        /// </summary>
        [JsonProperty("AcceptTimestamp")]
        public long? AcceptTimestamp{ get; set; }

        /// <summary>
        /// End timestamp. unix second-level timestamp.
        /// </summary>
        [JsonProperty("EndedTimestamp")]
        public long? EndedTimestamp{ get; set; }

        /// <summary>
        /// IVR key information, e.g. ["1","2","3"].
        /// </summary>
        [JsonProperty("IVRKeyPressed")]
        public string[] IVRKeyPressed{ get; set; }

        /// <summary>
        /// Hang-Up side, seat, user, system.
        /// </summary>
        [JsonProperty("HungUpSide")]
        public string HungUpSide{ get; set; }

        /// <summary>
        /// Service participant list.
        /// </summary>
        [JsonProperty("ServeParticipants")]
        public ServeParticipant[] ServeParticipants{ get; set; }

        /// <summary>
        /// Skill group id.
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public long? SkillGroupId{ get; set; }

        /// <summary>
        /// Refers to the EndStatus field.
        /// </summary>
        [JsonProperty("EndStatusString")]
        public string EndStatusString{ get; set; }

        /// <summary>
        /// Session start timestamp. unix second-level timestamp.
        /// </summary>
        [JsonProperty("StartTimestamp")]
        public long? StartTimestamp{ get; set; }

        /// <summary>
        /// Queue entry time. unix second-level timestamp.
        /// </summary>
        [JsonProperty("QueuedTimestamp")]
        public long? QueuedTimestamp{ get; set; }

        /// <summary>
        /// Post-IVR key information (e.g. [{"key":"1","label":"very satisfied"}]).
        /// </summary>
        [JsonProperty("PostIVRKeyPressed")]
        public IVRKeyPressedElement[] PostIVRKeyPressed{ get; set; }

        /// <summary>
        /// Queue skill group id.
        /// </summary>
        [JsonProperty("QueuedSkillGroupId")]
        public long? QueuedSkillGroupId{ get; set; }

        /// <summary>
        /// Session id.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Caller number protection id. effective when the number protection map feature is activated, and the caller field is empty.
        /// </summary>
        [JsonProperty("ProtectedCaller")]
        public string ProtectedCaller{ get; set; }

        /// <summary>
        /// Called number protection id. effective when the number protection map feature is activated, and the callee field is empty.
        /// </summary>
        [JsonProperty("ProtectedCallee")]
        public string ProtectedCallee{ get; set; }

        /// <summary>
        /// Customer custom data. (user - to - user interface).
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uui")]
        [System.Obsolete]
        public string Uui{ get; set; }

        /// <summary>
        /// Customer custom data. (user - to - user interface).
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }

        /// <summary>
        /// IVR key information (e.g. [{"key":"1","label":"very satisfied"}]).
        /// </summary>
        [JsonProperty("IVRKeyPressedEx")]
        public IVRKeyPressedElement[] IVRKeyPressedEx{ get; set; }

        /// <summary>
        /// Access to the asr text information address of the recording.
        /// </summary>
        [JsonProperty("AsrUrl")]
        public string AsrUrl{ get; set; }

        /// <summary>
        /// ASRUrl status: complete.
        /// Completed;.
        /// Processing.
        /// Generating.
        /// NotExists.
        /// No record (offline asr generation is not enabled or no package is available).
        /// </summary>
        [JsonProperty("AsrStatus")]
        public string AsrStatus{ get; set; }

        /// <summary>
        /// Address of the third-party cos for transferring recording.
        /// </summary>
        [JsonProperty("CustomRecordURL")]
        public string CustomRecordURL{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Queue skill group name.
        /// </summary>
        [JsonProperty("QueuedSkillGroupName")]
        public string QueuedSkillGroupName{ get; set; }

        /// <summary>
        /// Audio message recording url during call.
        /// </summary>
        [JsonProperty("VoicemailRecordURL")]
        public string[] VoicemailRecordURL{ get; set; }

        /// <summary>
        /// Text information address of asr audio message during a call.
        /// </summary>
        [JsonProperty("VoicemailAsrURL")]
        public string[] VoicemailAsrURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Caller", this.Caller);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "RecordURL", this.RecordURL);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamObj(map, prefix + "SeatUser.", this.SeatUser);
            this.SetParamSimple(map, prefix + "EndStatus", this.EndStatus);
            this.SetParamSimple(map, prefix + "SkillGroup", this.SkillGroup);
            this.SetParamSimple(map, prefix + "CallerLocation", this.CallerLocation);
            this.SetParamSimple(map, prefix + "IVRDuration", this.IVRDuration);
            this.SetParamSimple(map, prefix + "RingTimestamp", this.RingTimestamp);
            this.SetParamSimple(map, prefix + "AcceptTimestamp", this.AcceptTimestamp);
            this.SetParamSimple(map, prefix + "EndedTimestamp", this.EndedTimestamp);
            this.SetParamArraySimple(map, prefix + "IVRKeyPressed.", this.IVRKeyPressed);
            this.SetParamSimple(map, prefix + "HungUpSide", this.HungUpSide);
            this.SetParamArrayObj(map, prefix + "ServeParticipants.", this.ServeParticipants);
            this.SetParamSimple(map, prefix + "SkillGroupId", this.SkillGroupId);
            this.SetParamSimple(map, prefix + "EndStatusString", this.EndStatusString);
            this.SetParamSimple(map, prefix + "StartTimestamp", this.StartTimestamp);
            this.SetParamSimple(map, prefix + "QueuedTimestamp", this.QueuedTimestamp);
            this.SetParamArrayObj(map, prefix + "PostIVRKeyPressed.", this.PostIVRKeyPressed);
            this.SetParamSimple(map, prefix + "QueuedSkillGroupId", this.QueuedSkillGroupId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ProtectedCaller", this.ProtectedCaller);
            this.SetParamSimple(map, prefix + "ProtectedCallee", this.ProtectedCallee);
            this.SetParamSimple(map, prefix + "Uui", this.Uui);
            this.SetParamSimple(map, prefix + "UUI", this.UUI);
            this.SetParamArrayObj(map, prefix + "IVRKeyPressedEx.", this.IVRKeyPressedEx);
            this.SetParamSimple(map, prefix + "AsrUrl", this.AsrUrl);
            this.SetParamSimple(map, prefix + "AsrStatus", this.AsrStatus);
            this.SetParamSimple(map, prefix + "CustomRecordURL", this.CustomRecordURL);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "QueuedSkillGroupName", this.QueuedSkillGroupName);
            this.SetParamArraySimple(map, prefix + "VoicemailRecordURL.", this.VoicemailRecordURL);
            this.SetParamArraySimple(map, prefix + "VoicemailAsrURL.", this.VoicemailAsrURL);
        }
    }
}

