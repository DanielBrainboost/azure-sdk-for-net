// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> Metadata information used by account encryption. </summary>
    public partial class DataLakeStoreAccountKeyVaultMetaInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountKeyVaultMetaInfo"/>. </summary>
        /// <param name="keyVaultResourceId"> The resource identifier for the user managed Key Vault being used to encrypt. </param>
        /// <param name="encryptionKeyName"> The name of the user managed encryption key. </param>
        /// <param name="encryptionKeyVersion"> The version of the user managed encryption key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVaultResourceId"/>, <paramref name="encryptionKeyName"/> or <paramref name="encryptionKeyVersion"/> is null. </exception>
        public DataLakeStoreAccountKeyVaultMetaInfo(string keyVaultResourceId, string encryptionKeyName, string encryptionKeyVersion)
        {
            if (keyVaultResourceId == null)
            {
                throw new ArgumentNullException(nameof(keyVaultResourceId));
            }
            if (encryptionKeyName == null)
            {
                throw new ArgumentNullException(nameof(encryptionKeyName));
            }
            if (encryptionKeyVersion == null)
            {
                throw new ArgumentNullException(nameof(encryptionKeyVersion));
            }

            KeyVaultResourceId = keyVaultResourceId;
            EncryptionKeyName = encryptionKeyName;
            EncryptionKeyVersion = encryptionKeyVersion;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountKeyVaultMetaInfo"/>. </summary>
        /// <param name="keyVaultResourceId"> The resource identifier for the user managed Key Vault being used to encrypt. </param>
        /// <param name="encryptionKeyName"> The name of the user managed encryption key. </param>
        /// <param name="encryptionKeyVersion"> The version of the user managed encryption key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreAccountKeyVaultMetaInfo(string keyVaultResourceId, string encryptionKeyName, string encryptionKeyVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyVaultResourceId = keyVaultResourceId;
            EncryptionKeyName = encryptionKeyName;
            EncryptionKeyVersion = encryptionKeyVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreAccountKeyVaultMetaInfo"/> for deserialization. </summary>
        internal DataLakeStoreAccountKeyVaultMetaInfo()
        {
        }

        /// <summary> The resource identifier for the user managed Key Vault being used to encrypt. </summary>
        public string KeyVaultResourceId { get; set; }
        /// <summary> The name of the user managed encryption key. </summary>
        public string EncryptionKeyName { get; set; }
        /// <summary> The version of the user managed encryption key. </summary>
        public string EncryptionKeyVersion { get; set; }
    }
}
