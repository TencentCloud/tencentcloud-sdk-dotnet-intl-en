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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyUploadRequest : AbstractModel
    {
        
        /// <summary>
        /// Media type. For the detailed valid values, please see [Upload Overview](https://intl.cloud.tencent.com/document/product/266/9760?from_cn_redirect=1#.E6.96.87.E4.BB.B6.E7.B1.BB.E5.9E.8B).
        /// </summary>
        [JsonProperty("MediaType")]
        public string MediaType{ get; set; }

        /// <summary>
        /// Media name.
        /// </summary>
        [JsonProperty("MediaName")]
        public string MediaName{ get; set; }

        /// <summary>
        /// Cover type. For the detailed valid values, please see [Upload Overview](https://intl.cloud.tencent.com/document/product/266/9760?from_cn_redirect=1#.E6.96.87.E4.BB.B6.E7.B1.BB.E5.9E.8B).
        /// </summary>
        [JsonProperty("CoverType")]
        public string CoverType{ get; set; }

        /// <summary>
        /// Subsequent task operation on a media file, i.e., after a media file is uploaded, task flow operations will be initiated automatically. This parameter value is a task flow template name. VOD supports [creating task flow templates](https://intl.cloud.tencent.com/document/product/266/33819?from_cn_redirect=1) and naming the templates.
        /// </summary>
        [JsonProperty("Procedure")]
        public string Procedure{ get; set; }

        /// <summary>
        /// Expiration time of a media file in ISO 8601 format. For more information, please see [Notes on ISO Date Format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F).
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Specifies upload region. This is only applicable to users that have special requirements for the upload region.
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// Category ID, which is used to categorize the media for management. A category can be created and its ID can be obtained by using the [category creating](https://intl.cloud.tencent.com/document/product/266/7812?from_cn_redirect=1) API.
        /// <li>Default value: 0, which means "Other".</li>
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// Source context, which is used to pass through the user request information. The [upload callback](https://intl.cloud.tencent.com/document/product/266/7830?from_cn_redirect=1) API will return the value of this field. It can contain up to 250 characters.
        /// </summary>
        [JsonProperty("SourceContext")]
        public string SourceContext{ get; set; }

        /// <summary>
        /// Session context, which is used to pass through the user request information. If the `Procedure` parameter is specified, the [task flow status change callback](https://intl.cloud.tencent.com/document/product/266/9636?from_cn_redirect=1) API will return the value of this field. It can contain up to 1,000 characters.
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// Reserved field for special purposes.
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }

        /// <summary>
        /// ID of a [subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this field; otherwise, leave it empty.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MediaType", this.MediaType);
            this.SetParamSimple(map, prefix + "MediaName", this.MediaName);
            this.SetParamSimple(map, prefix + "CoverType", this.CoverType);
            this.SetParamSimple(map, prefix + "Procedure", this.Procedure);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "SourceContext", this.SourceContext);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

