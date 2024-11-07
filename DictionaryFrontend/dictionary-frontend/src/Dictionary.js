import React, { useState } from 'react';
import axios from 'axios';
import 'bootstrap/dist/css/bootstrap.min.css'; // Import Bootstrap CSS

const Dictionary = () => {
  const [word, setWord] = useState('');
  const [translation, setTranslation] = useState('');
  const [error, setError] = useState('');

  const handleTranslate = async () => {
    try {
      const response = await axios.get(`http://localhost:5188/api/dictionary/translate?word=${word}`);
      setTranslation(response.data);
      setError('');
    } catch (err) {
      setError('Translation not found.');
      setTranslation('');
    }
  };

  return (
    <div className="container-fluid" style={{ backgroundColor: '#FFFDD0', minHeight: '100vh' }}>
      <div className="container mt-5 d-flex justify-content-center">
        <div className="card bg-light shadow-lg p-4" style={{ maxWidth: '600px', width: '100%' }}>
          <h2 className="text-center mb-4 text-primary">English to Hungarian Dictionary</h2>
          <div className="mb-3">
            <div className="input-group">
              <input
                type="text"
                className="form-control"
                placeholder="Enter an English word"
                value={word}
                onChange={(e) => setWord(e.target.value)}
              />
              <button className="btn btn-primary" onClick={handleTranslate}>
                <i className="bi bi-translate"></i> Translate
              </button>
            </div>
          </div>
          {translation && (
            <div className="card mt-4 border-0">
              <div className="card-body bg-success text-white">
                <h5 className="card-title">Translation</h5>
                <p className="card-text">{translation}</p>
              </div>
            </div>
          )}
          {error && (
            <div className="card mt-4 border-0">
              <div className="card-body bg-danger text-white">
                <h5 className="card-title">Error</h5>
                <p className="card-text">{error}</p>
              </div>
            </div>
          )}
        </div>
      </div>
    </div>
  );
};

export default Dictionary;
