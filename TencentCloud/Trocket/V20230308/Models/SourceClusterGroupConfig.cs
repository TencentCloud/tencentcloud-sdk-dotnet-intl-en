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

    public class SourceClusterGroupConfig : AbstractModel
    {
        
        /// <summary>
        /// Consumer group name. It can be obtained from [SourceClusterGroupConfig](https://www.tencentcloud.com/document/api/1493/96031?from_cn_redirect=1#SourceClusterGroupConfig) returned by the API [DescribeSourceClusterGroupList](https://www.tencentcloud.com/document/api/1493/118006?from_cn_redirect=1).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// Remarks
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Specifies whether it has been imported. it is unavailable when used as an input parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Imported")]
        public bool? Imported{ get; set; }

        /// <summary>
        /// Namespace, valid for 4.x clusters only.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Import status.
        /// Unknown. specifies an unknown status.
        /// Success.
        /// Failure.
        /// AlreadyExists. specifies the resource already exists.
        /// 
        /// Used as an output parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ImportStatus")]
        public string ImportStatus{ get; set; }

        /// <summary>
        /// Namespace of 4.x. output usage.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NamespaceV4")]
        public string NamespaceV4{ get; set; }

        /// <summary>
        /// Consumer group name for version 4.x. output usage.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GroupNameV4")]
        public string GroupNameV4{ get; set; }

        /// <summary>
        /// Complete namespace for version 4.x. output usage.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FullNamespaceV4")]
        public string FullNamespaceV4{ get; set; }

        /// <summary>
        /// Specifies whether it is ordered delivery. valid value: 5.0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumeMessageOrderly")]
        public bool? ConsumeMessageOrderly{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Imported", this.Imported);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ImportStatus", this.ImportStatus);
            this.SetParamSimple(map, prefix + "NamespaceV4", this.NamespaceV4);
            this.SetParamSimple(map, prefix + "GroupNameV4", this.GroupNameV4);
            this.SetParamSimple(map, prefix + "FullNamespaceV4", this.FullNamespaceV4);
            this.SetParamSimple(map, prefix + "ConsumeMessageOrderly", this.ConsumeMessageOrderly);
        }
    }
}

