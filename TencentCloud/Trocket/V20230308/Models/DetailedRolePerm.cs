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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetailedRolePerm : AbstractModel
    {
        
        /// <summary>
        /// Resources corresponding to permissions.
        /// Specifies the topic name, which can be obtained from [TopicItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#TopicItem) returned by the api [DescribeTopicList](https://www.tencentcloud.comom/document/api/1493/96030?from_cn_redirect=1) or from the console.
        /// Specifies the consumer group name, which can be obtained from the api response of DescribeConsumerGroupList (https://www.tencentcloud.comom/document/api/1493/101535?from_cn_redirect=1) or the console.
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// Whether to enable production permission
        /// </summary>
        [JsonProperty("PermWrite")]
        public bool? PermWrite{ get; set; }

        /// <summary>
        /// Whether to enable consumption permission
        /// </summary>
        [JsonProperty("PermRead")]
        public bool? PermRead{ get; set; }

        /// <summary>
        /// Authorize resource type (Topic: theme; Group: consumption Group).
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// Resource remark.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "PermWrite", this.PermWrite);
            this.SetParamSimple(map, prefix + "PermRead", this.PermRead);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

