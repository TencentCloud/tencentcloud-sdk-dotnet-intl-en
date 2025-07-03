/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// **Scenario         EndStatus         EndStatusString         status description**.
        /// 
        /// Incoming and outgoing calls.
        /// 
        /// Incoming and outgoing calls	0	error	exception termination.
        /// 
        /// Inbound call 102 ivrGiveUp user hang up during IVR.
        /// 
        /// Inbound call 103 waitingGiveUp user gives up while queuing.
        /// 
        /// Inbound call 104 ringingGiveUp user give up during ringing.
        /// 
        /// Inbound call 105 no agent online.
        /// 
        /// Inbound call 106 notWorkTime outside working hours.   
        /// 
        /// Inbound call 107 ivrEnd ends after IVR.
        /// 
        /// Inbound call 100 blackList. 
        /// 
        /// Outbound call 2 unconnected unanswered.
        /// 
        /// Outgoing call        108        restrictedCallee    the callee is restricted due to high risk.
        /// 
        /// Outbound call 109 too many requests outbound over-frequency limit.
        /// 
        /// Outgoing call             110	        restrictedArea	    valid values for the area where outgoing calls are restricted.
        /// 
        /// Outbound call 111 restrictedTime outgoing call time limit.
        ///                          
        /// Outbound call 201 unknown unknown status.
        /// 
        /// Outgoing call 202 not answered the callee did not answer.
        /// 
        /// Outgoing call            203	    userReject	callee rejects and hangs up.
        /// 
        /// Outbound call 204 powerOff callee is powered off.
        /// 
        /// Outbound call 205 number does not exist the callee's number is non - existent.
        /// 
        /// Outbound call 206 busy callee is busy.
        /// 
        /// Outbound call 207 arrears callee in arrears.
        /// 
        /// Outbound call 208 operator channel exception.
        /// 
        /// Outbound call 209 callerCancel call cancellation by the caller.
        /// 
        /// Outgoing call 210 notInService callee out of service area.
        /// 
        /// Incoming and outgoing calls 211 clientError client errors.
        /// Outbound call 212 carrier blocked.
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
        /// EndStatus corresponds one-to-one with EndStatusString. the specific enumeration is as follows:.
        /// 
        /// **Scenario         EndStatus         EndStatusString         status description**.
        /// 
        /// Incoming and outgoing calls.
        /// 
        /// Incoming and outgoing calls	0	error	exception termination.
        /// 
        /// Inbound call 102 ivrGiveUp user hang up during IVR.
        /// 
        /// Inbound call 103 waitingGiveUp user gives up while queuing.
        /// 
        /// Inbound call 104 ringingGiveUp user give up during ringing.
        /// 
        /// Inbound call 105 no agent online.
        /// 
        /// Inbound call 106 notWorkTime outside working hours.   
        /// 
        /// Inbound call 107 ivrEnd ends after IVR.
        /// 
        /// Inbound call 100 blackList. 
        /// 
        /// Outbound call 2 unconnected unanswered.
        /// 
        /// Outgoing call        108        restrictedCallee    the callee is restricted due to high risk.
        /// 
        /// Outbound call 109 too many requests outbound over-frequency limit.
        /// 
        /// Outgoing call             110	        restrictedArea	    valid values for the area where outgoing calls are restricted.
        /// 
        /// Outbound call 111 restrictedTime outgoing call time limit.
        ///                          
        /// Outgoing call 201 unknown unknown status.
        /// 
        /// Outgoing call 202 notAnswer callee not answered.
        /// 
        /// Outgoing call            203	    userReject	callee rejects and hangs up.
        /// 
        /// Outbound call 204 powerOff callee is powered off.
        /// 
        /// Outbound call 205 number does not exist the callee's number is non - existent.
        /// 
        /// Outgoing call 206 busy callee is busy.
        /// 
        /// Outbound call 207 out of credit callee in arrears.
        /// 
        /// Outbound call 208 operator channel exception.
        /// 
        /// Outgoing call 209 callerCancel call cancellation by the caller.
        /// 
        /// Outgoing call 210 notInService callee out of service area.
        /// 
        /// Incoming and outgoing calls 211 clientError client errors.
        /// Outbound call 212 carrier blocked.
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

