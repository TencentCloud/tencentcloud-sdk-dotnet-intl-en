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

    public class AmazonS3Settings : AbstractModel
    {
        
        /// <summary>
        /// Access key ID of the S3 sub-account.
        /// </summary>
        [JsonProperty("AccessKeyID")]
        public string AccessKeyID{ get; set; }

        /// <summary>
        /// Secret access key of the S3 sub-account.
        /// </summary>
        [JsonProperty("SecretAccessKey")]
        public string SecretAccessKey{ get; set; }

        /// <summary>
        /// Region of S3.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Bucket name of S3.
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// File output path, which can be empty. If it is not empty, it starts with / and ends with /.
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// User-defined name, supports alphanumeric characters, underscores, and hyphens, with a length between 1 and 32 characters.
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// File suffix, only supports `jpg`.
        /// </summary>
        [JsonProperty("FileExt")]
        public string FileExt{ get; set; }

        /// <summary>
        /// Support `unix` or `utc0`, default unix.
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessKeyID", this.AccessKeyID);
            this.SetParamSimple(map, prefix + "SecretAccessKey", this.SecretAccessKey);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileExt", this.FileExt);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
        }
    }
}

