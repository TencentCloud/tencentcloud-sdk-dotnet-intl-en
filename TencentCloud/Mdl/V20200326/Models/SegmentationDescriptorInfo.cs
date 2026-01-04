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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SegmentationDescriptorInfo : AbstractModel
    {
        
        /// <summary>
        /// A 32-bit unique segmentation event identifier. Only one occurrence of a given segmentation_event_id value shall be active at any one time.
        /// </summary>
        [JsonProperty("EventID")]
        public ulong? EventID{ get; set; }

        /// <summary>
        /// Indicates that a previously sent segmentation event, identified by segmentation_event_id, has been cancelled.
        /// </summary>
        [JsonProperty("EventCancelIndicator")]
        public ulong? EventCancelIndicator{ get; set; }

        /// <summary>
        /// Distribution configuration.
        /// </summary>
        [JsonProperty("DeliveryRestrictions")]
        public DeliveryRestrictionsInfo DeliveryRestrictions{ get; set; }

        /// <summary>
        /// The duration of the segment in 90kHz ticks. indicat when the segment will be over and when the next segmentation message will occur.Shall be 0 for end messages.the time signal will continue until insert a cancellation message when not specify the duration.
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// Corresponds to SCTE-35 segmentation_upid_type parameter.
        /// </summary>
        [JsonProperty("UPIDType")]
        public ulong? UPIDType{ get; set; }

        /// <summary>
        /// Corresponds to SCTE-35 segmentation_upid. 
        /// </summary>
        [JsonProperty("UPID")]
        public string UPID{ get; set; }

        /// <summary>
        /// Corresponds to SCTE-35 segmentation_type_id.
        /// </summary>
        [JsonProperty("TypeID")]
        public ulong? TypeID{ get; set; }

        /// <summary>
        /// Corresponds to SCTE-35 segment_num. This field provides support for numbering segments within a given collection of segments.
        /// </summary>
        [JsonProperty("Num")]
        public ulong? Num{ get; set; }

        /// <summary>
        /// Corresponds to SCTE-35 segment_expected.This field provides a count of the expected number of individual segments within a collection of segments.
        /// </summary>
        [JsonProperty("Expected")]
        public ulong? Expected{ get; set; }

        /// <summary>
        /// Corresponds to SCTE-35 sub_segment_num.This field provides identification for a specific sub-segment within a collection of sub-segments.
        /// </summary>
        [JsonProperty("SubSegmentNum")]
        public ulong? SubSegmentNum{ get; set; }

        /// <summary>
        /// Corresponds to SCTE-35 sub_segments_expected.This field provides a count of the expected number of individual sub-segments within the collection of sub-segments.
        /// </summary>
        [JsonProperty("SubSegmentsExpected")]
        public ulong? SubSegmentsExpected{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventID", this.EventID);
            this.SetParamSimple(map, prefix + "EventCancelIndicator", this.EventCancelIndicator);
            this.SetParamObj(map, prefix + "DeliveryRestrictions.", this.DeliveryRestrictions);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "UPIDType", this.UPIDType);
            this.SetParamSimple(map, prefix + "UPID", this.UPID);
            this.SetParamSimple(map, prefix + "TypeID", this.TypeID);
            this.SetParamSimple(map, prefix + "Num", this.Num);
            this.SetParamSimple(map, prefix + "Expected", this.Expected);
            this.SetParamSimple(map, prefix + "SubSegmentNum", this.SubSegmentNum);
            this.SetParamSimple(map, prefix + "SubSegmentsExpected", this.SubSegmentsExpected);
        }
    }
}

