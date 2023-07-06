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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventSettingsReq : AbstractModel
    {
        
        /// <summary>
        /// Valid values: `INPUT_SWITCH`, `TIMED_RECORD`. If it is not specified, `INPUT_SWITCH` will be used.
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// ID of the input to attach, which is required if `EventType` is `INPUT_SWITCH`
        /// </summary>
        [JsonProperty("InputAttachment")]
        public string InputAttachment{ get; set; }

        /// <summary>
        /// Name of the output group to attach. This parameter is required if `EventType` is `TIMED_RECORD`.
        /// </summary>
        [JsonProperty("OutputGroupName")]
        public string OutputGroupName{ get; set; }

        /// <summary>
        /// Name of the manifest file for timed recording, which must end with `.m3u8` for HLS and `.mpd` for DASH. This parameter is required if `EventType` is `TIMED_RECORD`.
        /// </summary>
        [JsonProperty("ManifestName")]
        public string ManifestName{ get; set; }

        /// <summary>
        /// URL of the COS bucket to save recording files. This parameter is required if `EventType` is `TIMED_RECORD`. It may contain 1 or 2 URLs. The first URL corresponds to pipeline 0 and the second pipeline 1.
        /// </summary>
        [JsonProperty("Destinations")]
        public EventSettingsDestinationReq[] Destinations{ get; set; }

        /// <summary>
        /// SCTE-35 configuration information.
        /// </summary>
        [JsonProperty("SCTE35SegmentationDescriptor")]
        public SegmentationDescriptorInfo[] SCTE35SegmentationDescriptor{ get; set; }

        /// <summary>
        /// A 32-bit unique segmentation event identifier.Only one occurrence of a given segmentation_event_id value shall be active at any one time.
        /// </summary>
        [JsonProperty("SpliceEventID")]
        public ulong? SpliceEventID{ get; set; }

        /// <summary>
        /// The duration of the segment in 90kHz ticks.It used to  give the splicer an indication of when the break will be over and when the network In Point will occur. If not specifyed,the splice_insert will continue when enter a return_to_network to end the splice_insert at the appropriate time.
        /// </summary>
        [JsonProperty("SpliceDuration")]
        public ulong? SpliceDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "InputAttachment", this.InputAttachment);
            this.SetParamSimple(map, prefix + "OutputGroupName", this.OutputGroupName);
            this.SetParamSimple(map, prefix + "ManifestName", this.ManifestName);
            this.SetParamArrayObj(map, prefix + "Destinations.", this.Destinations);
            this.SetParamArrayObj(map, prefix + "SCTE35SegmentationDescriptor.", this.SCTE35SegmentationDescriptor);
            this.SetParamSimple(map, prefix + "SpliceEventID", this.SpliceEventID);
            this.SetParamSimple(map, prefix + "SpliceDuration", this.SpliceDuration);
        }
    }
}

