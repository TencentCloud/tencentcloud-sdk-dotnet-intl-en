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

    public class DescribeSessionDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <P>Calling number</p>.
        /// </summary>
        [JsonProperty("Caller")]
        public string Caller{ get; set; }

        /// <summary>
        /// <P>Called number</p>.
        /// </summary>
        [JsonProperty("Callee")]
        public string Callee{ get; set; }

        /// <summary>
        /// <P>Call type 1 outgoing call 2 incoming call 3 audio dial-in 5 predictive outbound call 6 extension call</p>.
        /// </summary>
        [JsonProperty("CallType")]
        public long? CallType{ get; set; }

        /// <summary>
        /// <p>Start timestamp, Unix second-level timestamp</p>.
        /// </summary>
        [JsonProperty("StartTimeStamp")]
        public long? StartTimeStamp{ get; set; }

        /// <summary>
        /// <p>Ring timestamp, UNIX second-level timestamp</p>.
        /// </summary>
        [JsonProperty("RingTimestamp")]
        public long? RingTimestamp{ get; set; }

        /// <summary>
        /// <p>Answer timestamp, UNIX second-level timestamp</p>.
        /// </summary>
        [JsonProperty("AcceptTimestamp")]
        public long? AcceptTimestamp{ get; set; }

        /// <summary>
        /// <p>End timestamp, UNIX second-level timestamp</p>.
        /// </summary>
        [JsonProperty("EndedTimestamp")]
        public long? EndedTimestamp{ get; set; }

        /// <summary>
        /// <p>Queue entry time, Unix second-level timestamp</p>.
        /// </summary>
        [JsonProperty("QueuedTimestamp")]
        public long? QueuedTimestamp{ get; set; }

        /// <summary>
        /// <P>Agent account</p>.
        /// </summary>
        [JsonProperty("StaffUserId")]
        public string StaffUserId{ get; set; }

        /// <summary>
        /// <p>Refer to the EndStatus field in the DescribeTelCdr api.</p>.
        /// </summary>
        [JsonProperty("EndStatus")]
        public long? EndStatus{ get; set; }

        /// <summary>
        /// <p>Queue skill group ID</p>.
        /// </summary>
        [JsonProperty("QueuedSkillGroupId")]
        public long? QueuedSkillGroupId{ get; set; }

        /// <summary>
        /// <P>Queue skill group name</p>.
        /// </summary>
        [JsonProperty("QueuedSkillGroupName")]
        public string QueuedSkillGroupName{ get; set; }

        /// <summary>
        /// <P>The recording link comes with authentication and a valid period. after obtaining it, please retrieve the content within 24 hours. do not persist this link. if the link has expired, call this api again to get a new link.</p>.
        /// </summary>
        [JsonProperty("RecordURL")]
        public string RecordURL{ get; set; }

        /// <summary>
        /// <p>Recording transfer to external COS link</p>.
        /// </summary>
        [JsonProperty("CustomRecordURL")]
        public string CustomRecordURL{ get; set; }

        /// <summary>
        /// <P>Text information link of the voice recording, with authentication and valid period. please retrieve it within 24 hr after obtaining. do not persist this link. if the link has expired, call this api again to get a new link.</p>.
        /// </summary>
        [JsonProperty("AsrURL")]
        public string AsrURL{ get; set; }

        /// <summary>
        /// <P>Voicemail recording link</p>.
        /// </summary>
        [JsonProperty("VoicemailRecordURL")]
        public string[] VoicemailRecordURL{ get; set; }

        /// <summary>
        /// <P>Voicemail voice recording text information link. you need to purchase an offline speech recognition package through the console and enable the offline speech recognition switch.</p>.
        /// </summary>
        [JsonProperty("VoicemailAsrURL")]
        public string[] VoicemailAsrURL{ get; set; }

        /// <summary>
        /// <P>IVR key information</p>.
        /// </summary>
        [JsonProperty("IVRKeyPressed")]
        public IVRKeyPressedElement[] IVRKeyPressed{ get; set; }

        /// <summary>
        /// <P>Key information of satisfaction rate</p>.
        /// </summary>
        [JsonProperty("PostIVRKeyPressed")]
        public IVRKeyPressedElement[] PostIVRKeyPressed{ get; set; }

        /// <summary>
        /// <P>Hang-Up side seat agent user system</p>.
        /// </summary>
        [JsonProperty("HungUpSide")]
        public string HungUpSide{ get; set; }

        /// <summary>
        /// <p>Customer custom data (User-to-User Interface)</p>.
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }

        /// <summary>
        /// <P>Event list for calls in progress</p>.
        /// </summary>
        [JsonProperty("Events")]
        public SessionEvent[] Events{ get; set; }

        /// <summary>
        /// <P>Service participant list</p>.
        /// </summary>
        [JsonProperty("ServeParticipants")]
        public ServeParticipant[] ServeParticipants{ get; set; }

        /// <summary>
        /// <P>Status code for reason of system hang-up after connect.</p><p><a href="https://www.tencentcloud.com/document/product/679/123938?from_cn_redirect=1">details</a></p>.
        /// </summary>
        [JsonProperty("SysHangupReason")]
        public long? SysHangupReason{ get; set; }

        /// <summary>
        /// <P>Reason for system hang up after connect.</p><p><a href="https://www.tencentcloud.com/document/product/679/123938?from_cn_redirect=1">details</a></p>.
        /// </summary>
        [JsonProperty("SysHangupReasonString")]
        public string SysHangupReasonString{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Caller", this.Caller);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
            this.SetParamSimple(map, prefix + "StartTimeStamp", this.StartTimeStamp);
            this.SetParamSimple(map, prefix + "RingTimestamp", this.RingTimestamp);
            this.SetParamSimple(map, prefix + "AcceptTimestamp", this.AcceptTimestamp);
            this.SetParamSimple(map, prefix + "EndedTimestamp", this.EndedTimestamp);
            this.SetParamSimple(map, prefix + "QueuedTimestamp", this.QueuedTimestamp);
            this.SetParamSimple(map, prefix + "StaffUserId", this.StaffUserId);
            this.SetParamSimple(map, prefix + "EndStatus", this.EndStatus);
            this.SetParamSimple(map, prefix + "QueuedSkillGroupId", this.QueuedSkillGroupId);
            this.SetParamSimple(map, prefix + "QueuedSkillGroupName", this.QueuedSkillGroupName);
            this.SetParamSimple(map, prefix + "RecordURL", this.RecordURL);
            this.SetParamSimple(map, prefix + "CustomRecordURL", this.CustomRecordURL);
            this.SetParamSimple(map, prefix + "AsrURL", this.AsrURL);
            this.SetParamArraySimple(map, prefix + "VoicemailRecordURL.", this.VoicemailRecordURL);
            this.SetParamArraySimple(map, prefix + "VoicemailAsrURL.", this.VoicemailAsrURL);
            this.SetParamArrayObj(map, prefix + "IVRKeyPressed.", this.IVRKeyPressed);
            this.SetParamArrayObj(map, prefix + "PostIVRKeyPressed.", this.PostIVRKeyPressed);
            this.SetParamSimple(map, prefix + "HungUpSide", this.HungUpSide);
            this.SetParamSimple(map, prefix + "UUI", this.UUI);
            this.SetParamArrayObj(map, prefix + "Events.", this.Events);
            this.SetParamArrayObj(map, prefix + "ServeParticipants.", this.ServeParticipants);
            this.SetParamSimple(map, prefix + "SysHangupReason", this.SysHangupReason);
            this.SetParamSimple(map, prefix + "SysHangupReasonString", this.SysHangupReasonString);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

