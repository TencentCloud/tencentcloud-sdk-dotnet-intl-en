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
        /// EndStatus corresponds one-to-one with endstatusstring, with specific enumerations as follows:.
        /// 
        /// **Scenario	EndStatus	EndStatusString	Status description**.
        /// 
        /// Inbound call & call	1	ok	end properly.
        /// 
        /// Inbound call & call | 0 | error | system error.
        /// 
        /// Inbound call | 102 | ivrgiveup | user gives up during ivr.
        /// 
        /// Inbound call | 103 | waitinggiveup | user gives up during session queue.
        /// 
        /// Inbound call | 104 | ringinggiveup | user gives up during session ringing.
        /// 
        /// Inbound call | 105 | noseatonline | no agent online.
        /// 
        /// Inbound call              106	       non - working hour      non - working hour.   
        /// 
        /// Inbound call              107	       ivrend                   end directly after ivr.
        /// 
        /// Inbound call              100	       blocklist call - in      call - in blocklist. 
        /// 
        /// Outgoing call            2                 unconnected            unconnected.
        /// 
        /// Outgoing call            108           restricted callee      callee restricted due to high - risk.
        /// 
        /// Outgoing call         109        toomanyrequest        overfrequency.
        /// 
        /// Outgoing call         110        restrictedarea        outbound blind area.
        /// 
        /// Outgoing call         111        restrictedtime        outbound time restriction.
        ///                          
        /// Outgoing call         201        unknown               unknown status.
        /// 
        /// Outgoing call         202        notanswer             unanswered.
        /// 
        /// Outgoing call - 203 - userreject: reject call.
        /// 
        /// Outgoing call - 204 - poweroff: power off.
        /// 
        /// Outgoing call - 205 - numbernotexist: nonexistent number.
        /// 
        /// Outgoing call - 206 - busy: call in progress.
        /// 
        /// Outgoing call - 207 - outofcredit: arrears.
        /// 
        /// Outgoing call - 208 - operatorerror - ISP line exception.
        /// 
        /// Outgoing call - 209 - callercancel - caller cancellation.
        /// 
        /// Outgoing call - 210 - notinservice - not in service area.
        /// 
        /// Inbound and outgoing call - 211 - clienterror - client error.
        /// Outgoing call - 212 - carrierblocked - ISP blocking.
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
        /// EndStatus corresponds one-to-one with endstatusstring, with specific enumerations as follows:.
        /// 
        /// **Scenario	EndStatus	EndStatusString	Status description**.
        /// 
        /// Inbound call & call	1	ok	end properly.
        /// 
        /// Inbound call & call | 0 | error | system error.
        /// 
        /// Inbound call | 102 | ivrgiveup | user gives up during ivr.
        /// 
        /// Inbound call | 103 | waitinggiveup | user gives up during session queue.
        /// 
        /// Inbound call | 104 | ringinggiveup | user gives up during session ringing.
        /// 
        /// Inbound call | 105 | noseatonline | no agent online.
        /// 
        /// Inbound call              106	       non - working hour      non - working hour.   
        /// 
        /// Inbound call              107	       ivrend                   end directly after ivr.
        /// 
        /// Inbound call              100	       blocklist call - in      call - in blocklist. 
        /// 
        /// Outgoing call            2                 unconnected            unconnected.
        /// 
        /// Outgoing call            108           restricted callee      callee restricted due to high - risk.
        /// 
        /// Outgoing call         109        toomanyrequest        overfrequency.
        /// 
        /// Outgoing call         110        restrictedarea        outbound blind area.
        /// 
        /// Outgoing call         111        restrictedtime        outbound time restriction.
        ///                          
        /// Outgoing call         201        unknown               unknown status.
        /// 
        /// Outgoing call         202        notanswer             unanswered.
        /// 
        /// Outgoing call - 203 - userreject: reject call.
        /// 
        /// Outgoing call - 204 - poweroff: power off.
        /// 
        /// Outgoing call - 205 - numbernotexist: nonexistent number.
        /// 
        /// Outgoing call - 206 - busy: call in progress.
        /// 
        /// Outgoing call - 207 - outofcredit: arrears.
        /// 
        /// Outgoing call - 208 - operatorerror - ISP line exception.
        /// 
        /// Outgoing call - 209 - callercancel - caller cancellation.
        /// 
        /// Outgoing call - 210 - notinservice - not in service area.
        /// 
        /// Inbound and outgoing call - 211 - clienterror - client error.
        /// Outgoing call - 212 - carrierblocked - ISP blocking.
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

