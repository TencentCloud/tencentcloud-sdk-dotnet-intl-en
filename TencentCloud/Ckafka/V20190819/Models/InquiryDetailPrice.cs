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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryDetailPrice : AbstractModel
    {
        
        /// <summary>
        /// Price of additional private network bandwidth
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BandwidthPrice")]
        public InquiryBasePrice BandwidthPrice{ get; set; }

        /// <summary>
        /// Disk price
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskPrice")]
        public InquiryBasePrice DiskPrice{ get; set; }

        /// <summary>
        /// Price of additional partitions
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PartitionPrice")]
        public InquiryBasePrice PartitionPrice{ get; set; }

        /// <summary>
        /// Price of additional topics
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicPrice")]
        public InquiryBasePrice TopicPrice{ get; set; }

        /// <summary>
        /// Instance package price
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceTypePrice")]
        public InquiryBasePrice InstanceTypePrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BandwidthPrice.", this.BandwidthPrice);
            this.SetParamObj(map, prefix + "DiskPrice.", this.DiskPrice);
            this.SetParamObj(map, prefix + "PartitionPrice.", this.PartitionPrice);
            this.SetParamObj(map, prefix + "TopicPrice.", this.TopicPrice);
            this.SetParamObj(map, prefix + "InstanceTypePrice.", this.InstanceTypePrice);
        }
    }
}

