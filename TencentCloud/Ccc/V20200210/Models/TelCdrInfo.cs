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
        /// Call initiation timestamp, Unix timestamp.
        /// </summary>
        [JsonProperty("Time")]
        public long? Time{ get; set; }

        /// <summary>
        /// Call direction: 0 - Inbound, 1 - Outbound.
        /// </summary>
        [JsonProperty("Direction")]
        public long? Direction{ get; set; }

        /// <summary>
        /// Call duration.
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// Recording Information.
        /// </summary>
        [JsonProperty("RecordURL")]
        public string RecordURL{ get; set; }

        /// <summary>
        /// Recording ID.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// Agent Information
        /// </summary>
        [JsonProperty("SeatUser")]
        public SeatUserInfo SeatUser{ get; set; }

        /// <summary>
        /// EndStatus corresponds one-to-one with EndStatusString, specific enumerations are as follows:
        /// 
        /// **Scenario	         EndStatus	EndStatusString	Status Description**
        /// 
        /// Incoming & Outgoing Calls	1	        ok	                        Normal End
        /// 
        /// Incoming & Outgoing Calls	0	        error	                System Error
        /// 
        /// Incoming Call	             102	        ivrGiveUp	        User Gave Up During IVR
        /// 
        /// Incoming Call	             103	        waitingGiveUp	       User Gave Up During Queue
        /// 
        /// Incoming Call	             104	        ringingGiveUp	       User Gave Up During Ringing
        /// 
        /// Incoming Call	             105	        noSeatOnline	       No Seat Online
        /// 
        /// Incoming Call              106	       notWorkTime	       Non-Working Hours   
        /// 
        /// Incoming Call	            107	       ivrEnd	               Ended Directly After IVR
        /// 
        /// Incoming Call	            100	      blackList Incoming blocklist  
        /// 
        /// Outgoing Call               2	              unconnected	Unconnected
        /// 
        /// Outgoing Call             108	        restrictedCallee	Callee restricted due to high risk
        /// 
        /// Outgoing Call             109	        tooManyRequest	    Frequency limit exceeded
        /// 
        /// Outgoing Call             110	        restrictedArea	    Call to restricted area
        /// 
        /// Outgoing Call             111	        restrictedTime	Call time restricted
        ///                          
        /// Outgoing Call             201            unknown	Unknown status
        /// 
        /// Outgoing Call             202            notAnswer	Missed call
        /// 
        /// Outgoing Call            203	    userReject	Reject/Hang Up
        /// 
        /// Outgoing Call	          204	    powerOff	Shutting down
        /// 
        /// Outgoing Call           205            numberNotExist	Disconnected Number
        /// 
        /// Outgoing Call	         206	           busy	During the call
        /// 
        /// Outgoing Call   	        207	           outOfCredit	Overdue Payment
        /// 
        /// Outgoing Call	         208	           operatorError	 ISP Carrier Line Anomaly
        /// 
        /// Outgoing Call         	209	           callerCancel	Caller Cancelled
        /// 
        /// Outgoing Call	        210	           notInService	Out of Service Area
        /// 
        /// Incoming & Outgoing Calls	211    clientError    Client Error
        /// </summary>
        [JsonProperty("EndStatus")]
        public long? EndStatus{ get; set; }

        /// <summary>
        /// Skill group name.
        /// </summary>
        [JsonProperty("SkillGroup")]
        public string SkillGroup{ get; set; }

        /// <summary>
        /// Caller's location.
        /// </summary>
        [JsonProperty("CallerLocation")]
        public string CallerLocation{ get; set; }

        /// <summary>
        /// Time spent in IVR stage.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IVRDuration")]
        public long? IVRDuration{ get; set; }

        /// <summary>
        /// Ring timestamp. UNIX second-level timestamp
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RingTimestamp")]
        public long? RingTimestamp{ get; set; }

        /// <summary>
        /// Answer timestamp. UNIX second-Level timestamp
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AcceptTimestamp")]
        public long? AcceptTimestamp{ get; set; }

        /// <summary>
        /// End timestamp. UNIX second-level timestamp
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndedTimestamp")]
        public long? EndedTimestamp{ get; set; }

        /// <summary>
        /// IVR key information, e.g. ["1","2","3"]
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IVRKeyPressed")]
        public string[] IVRKeyPressed{ get; set; }

        /// <summary>
        /// Hanging Up Party seat Seat user Users system system
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HungUpSide")]
        public string HungUpSide{ get; set; }

        /// <summary>
        /// List of Service Participants
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServeParticipants")]
        public ServeParticipant[] ServeParticipants{ get; set; }

        /// <summary>
        /// Skill group ID.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public long? SkillGroupId{ get; set; }

        /// <summary>
        /// EndStatus corresponds one-to-one with EndStatusString, specific enumerations are as follows:
        /// 
        /// **Scenario	         EndStatus	EndStatusString	Status Description**
        /// 
        /// Incoming & Outgoing Calls	1	        ok	                        Normal End
        /// 
        /// Incoming & Outgoing Calls	0	        error	                System Error
        /// 
        /// Incoming Call	             102	        ivrGiveUp	        User Gave Up During IVR
        /// 
        /// Incoming Call	             103	        waitingGiveUp	       User Gave Up During Queue
        /// 
        /// Incoming Call	             104	        ringingGiveUp	       User Gave Up During Ringing
        /// 
        /// Incoming Call	             105	        noSeatOnline	       No Seat Online
        /// 
        /// Incoming Call              106	       notWorkTime	       Non-Working Hours   
        /// 
        /// Incoming Call	            107	       ivrEnd	               Ended Directly After IVR
        /// 
        /// Incoming Call	            100	      blackList Incoming blocklist  
        /// 
        /// Outgoing Call               2	              unconnected	Unconnected
        /// 
        /// Outgoing Call             108	        restrictedCallee	Callee restricted due to high risk
        /// 
        /// Outgoing Call             109	        tooManyRequest	    Frequency limit exceeded
        /// 
        /// Outgoing Call             110	        restrictedArea	    Call to restricted area
        /// 
        /// Outgoing Call             111	        restrictedTime	Call time restricted
        ///                          
        /// Outgoing Call             201            unknown	Unknown status
        /// 
        /// Outgoing Call             202            notAnswer	Missed call
        /// 
        /// Outgoing Call            203	    userReject	Reject/Hang Up
        /// 
        /// Outgoing Call	          204	    powerOff	Shutting down
        /// 
        /// Outgoing Call           205            numberNotExist	Disconnected Number
        /// 
        /// Phone Call Out	         206	           busy	In Call
        /// 
        /// Outgoing Call   	        207	           outOfCredit	Overdue Payment
        /// 
        /// Outgoing Call	         208	           operatorError	 ISP Carrier Line Anomaly
        /// 
        /// Outgoing Call         	209	           callerCancel	Caller Cancelled
        /// 
        /// Outgoing Call	        210	           notInService	Out of Service Area
        /// 
        /// Phone Call In & Out	211    clientError    Client Error
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndStatusString")]
        public string EndStatusString{ get; set; }

        /// <summary>
        /// Session start timestamp. UNIX second-level timestamp.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("StartTimestamp")]
        public long? StartTimestamp{ get; set; }

        /// <summary>
        /// Queue entry time. Unix second-level timestamp.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("QueuedTimestamp")]
        public long? QueuedTimestamp{ get; set; }

        /// <summary>
        /// Post-IVR key information (e.g. [{"Key":"1","Label":"Very Satisfied"}])
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PostIVRKeyPressed")]
        public IVRKeyPressedElement[] PostIVRKeyPressed{ get; set; }

        /// <summary>
        /// Queue Skill Group ID.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("QueuedSkillGroupId")]
        public long? QueuedSkillGroupId{ get; set; }

        /// <summary>
        /// Session ID.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Caller number protection ID. (Effective when the number protection map feature is activated, and the Caller field is empty).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProtectedCaller")]
        public string ProtectedCaller{ get; set; }

        /// <summary>
        /// Called number protection ID (Effective when the number protection map feature is activated, and the Callee field is empty).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProtectedCallee")]
        public string ProtectedCallee{ get; set; }

        /// <summary>
        /// Customer custom data. (User-to-User Interface)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uui")]
        [System.Obsolete]
        public string Uui{ get; set; }

        /// <summary>
        /// Customer custom data. (User-to-User Interface)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }

        /// <summary>
        /// IVR key information (e.g.?[{"Key":"1","Label":"highly satisfied"}])
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IVRKeyPressedEx")]
        public IVRKeyPressedElement[] IVRKeyPressedEx{ get; set; }

        /// <summary>
        /// Access to the ASR text information address of the recording.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AsrUrl")]
        public string AsrUrl{ get; set; }

        /// <summary>
        /// Address of the third party COS for transferring recording.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CustomRecordURL")]
        public string CustomRecordURL{ get; set; }

        /// <summary>
        /// Remarks
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Queue skill group name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QueuedSkillGroupName")]
        public string QueuedSkillGroupName{ get; set; }

        /// <summary>
        /// Audio message recording URL during call.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VoicemailRecordURL")]
        public string[] VoicemailRecordURL{ get; set; }

        /// <summary>
        /// Text Information address of ASR audio message during a call.
        /// Note: This field may return null, indicating that no valid values can be obtained.
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
            this.SetParamSimple(map, prefix + "CustomRecordURL", this.CustomRecordURL);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "QueuedSkillGroupName", this.QueuedSkillGroupName);
            this.SetParamArraySimple(map, prefix + "VoicemailRecordURL.", this.VoicemailRecordURL);
            this.SetParamArraySimple(map, prefix + "VoicemailAsrURL.", this.VoicemailAsrURL);
        }
    }
}

